﻿using System;
using System.Data;
using FDS_application;
using FDS_application.UserControls;
using MySql.Data.MySqlClient;

public class CustomerDAO
{
    private static CustomerDAO instance;
    private string username;
    private string password;
    private string connectionString;
    //private bool isCustomerDesign = false;


    public void setUser(string username, string password)
    {
        this.username = username;
        this.password = password;
        // Assuming MySQL connection for the given example
        this.connectionString = $"datasource=localhost;port=3307;username={this.username};password={this.password};database=db_infinytarwerks";
    }
    public static CustomerDAO Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new CustomerDAO();
            }
            return instance;
        }
    }

    public bool InsertCustomer(string firstName, string lastName, string phoneNo)
    {
        try
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Check if the customer with the same name and phone number already exists
                string checkCustomerQuery = "SELECT c.customer_id, p.phone_no FROM tb_customers c " +
                                            "LEFT JOIN tb_cust_phone_num p ON c.customer_id = p.customer_id " +
                                            "WHERE c.first_name = @FirstName AND c.last_name = @LastName";

                using (MySqlCommand checkCustomerCommand = new MySqlCommand(checkCustomerQuery, connection))
                {
                    checkCustomerCommand.Parameters.AddWithValue("@FirstName", firstName);
                    checkCustomerCommand.Parameters.AddWithValue("@LastName", lastName);

                    using (MySqlDataReader reader = checkCustomerCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Customer with the same name exists
                            int existingCustomerId = reader.GetInt32("customer_id");
                            string existingPhoneNo = reader.IsDBNull(reader.GetOrdinal("phone_no")) ? null : reader.GetString("phone_no");

                            if (existingPhoneNo == phoneNo)
                            {
                                // Phone number is the same, return true (insert successful) and use the existing customer ID
                                return true;
                            }
                            else
                            {
                                // Close the reader before executing another query
                                reader.Close();

                                // Phone number is different, add to tb_cust_phone_num
                                using (MySqlConnection phoneConnection = new MySqlConnection(connectionString))
                                {
                                    phoneConnection.Open();

                                    string insertNumQuery = "INSERT INTO tb_cust_phone_num (customer_id, phone_no) VALUES (@CustomerId, @PhoneNo)";
                                    using (MySqlCommand insertNumCommand = new MySqlCommand(insertNumQuery, phoneConnection))
                                    {
                                        insertNumCommand.Parameters.AddWithValue("@CustomerId", existingCustomerId);
                                        insertNumCommand.Parameters.AddWithValue("@PhoneNo", phoneNo);

                                        int numrowsAffected = insertNumCommand.ExecuteNonQuery();

                                        return numrowsAffected > 0;
                                    }
                                }
                            }
                        }
                    }
                }

                // Customer does not exist, proceed with insertion
                string insertCustomerQuery = "INSERT INTO tb_customers (first_name, last_name) VALUES (@FirstName, @LastName); SELECT LAST_INSERT_ID();";
                using (MySqlCommand insertCustomerCommand = new MySqlCommand(insertCustomerQuery, connection))
                {
                    insertCustomerCommand.Parameters.AddWithValue("@FirstName", char.ToUpper(firstName[0]) + firstName.Substring(1));
                    insertCustomerCommand.Parameters.AddWithValue("@LastName", char.ToUpper(lastName[0]) + lastName.Substring(1));

                    // Execute the query and retrieve the generated customer ID
                    int customerId = Convert.ToInt32(insertCustomerCommand.ExecuteScalar());

                    // Now, insert the phone number into tb_cust_phone_num
                    using (MySqlConnection phoneConnection = new MySqlConnection(connectionString))
                    {
                        phoneConnection.Open();

                        string insertPhoneQuery = "INSERT INTO tb_cust_phone_num (customer_id, phone_no) VALUES (@CustomerId, @PhoneNo)";
                        using (MySqlCommand insertPhoneCommand = new MySqlCommand(insertPhoneQuery, phoneConnection))
                        {
                            insertPhoneCommand.Parameters.AddWithValue("@CustomerId", customerId);
                            insertPhoneCommand.Parameters.AddWithValue("@PhoneNo", phoneNo);

                            int rowsAffected = insertPhoneCommand.ExecuteNonQuery();

                            return rowsAffected > 0;
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            // Handle exceptions appropriately (log, throw, etc.)
            Console.WriteLine($"Error inserting customer: {ex.Message}");
            return false;
        }
    }
    public int InsertOrganization(string customerId, string orgName)
    {
        try
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Check if the organization already exists for the customer
                string checkOrganizationQuery = "SELECT org_id FROM tb_cust_organization WHERE customer_id = @CustomerId AND org_name = @OrgName";
                using (MySqlCommand checkOrganizationCommand = new MySqlCommand(checkOrganizationQuery, connection))
                {
                    checkOrganizationCommand.Parameters.AddWithValue("@CustomerId", customerId);
                    checkOrganizationCommand.Parameters.AddWithValue("@OrgName", orgName);

                    object orgIdObject = checkOrganizationCommand.ExecuteScalar();

                    if (orgIdObject != null)
                    {
                        // Organization already exists for the customer
                        return Convert.ToInt32(orgIdObject);
                    }
                }

                // Organization does not exist, proceed with insertion
                string insertOrganizationQuery = "INSERT INTO tb_cust_organization (customer_id, org_name) VALUES (@CustomerId, @OrgName); SELECT LAST_INSERT_ID();";
                MySqlCommand insertOrganizationCommand = new MySqlCommand(insertOrganizationQuery, connection);

                insertOrganizationCommand.Parameters.AddWithValue("@CustomerId", customerId);
                insertOrganizationCommand.Parameters.AddWithValue("@OrgName", orgName);

                // Execute the query and retrieve the generated organization ID
                int orgId = Convert.ToInt32(insertOrganizationCommand.ExecuteScalar());

                return orgId;
            }
        }
        catch (Exception ex)
        {
            // Handle exceptions appropriately (log, throw, etc.)
            Console.WriteLine($"Error inserting organization: {ex.Message}");
            return -1; // Indicate failure
        }
    }
    public string GetCustomerId(string firstName, string lastName)
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            connection.Open();

            string getCustomerIdQuery = "SELECT customer_id FROM tb_customers WHERE first_name = @FirstName AND last_name = @LastName";
            MySqlCommand getCustomerIdCommand = new MySqlCommand(getCustomerIdQuery, connection);
            getCustomerIdCommand.Parameters.AddWithValue("@FirstName", firstName);
            getCustomerIdCommand.Parameters.AddWithValue("@LastName", lastName);

            return getCustomerIdCommand.ExecuteScalar().ToString();
        }
    }
    public int InsertOrderTransaction(string customerId, int? orgId, DateTime orderDate, bool isCustomerDesign)
    {
        try
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Insert order transaction
                        string insertOrderTransactionQuery = "INSERT INTO tb_order_transaction (customer_id, org_id, order_date, is_customer_design) " +
                                                              "VALUES (@CustomerId, @OrgId, @OrderDate, @IsCustomerDesign); SELECT LAST_INSERT_ID();";
                        MySqlCommand insertOrderTransactionCommand = new MySqlCommand(insertOrderTransactionQuery, connection, transaction);

                        insertOrderTransactionCommand.Parameters.AddWithValue("@CustomerId", customerId);
                        insertOrderTransactionCommand.Parameters.AddWithValue("@OrgId", orgId);
                        insertOrderTransactionCommand.Parameters.AddWithValue("@OrderDate", orderDate);
                        insertOrderTransactionCommand.Parameters.AddWithValue("@IsCustomerDesign", isCustomerDesign);

                        // Execute the query and retrieve the generated order ID
                        int orderId = Convert.ToInt32(insertOrderTransactionCommand.ExecuteScalar());

                        // Commit the transaction if everything is successful
                        transaction.Commit();

                        return orderId;
                    }
                    catch (Exception ex)
                    {
                        // Rollback the transaction on failure
                        transaction.Rollback();
                        Console.WriteLine($"Error inserting order transaction: {ex.Message}");
                        return -1; // Indicate failure
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error opening connection: {ex.Message}");
            return -1; // Indicate failure
        }
    }
    public int InsertOrderItem(int orderId, string sku, int quantity, string size)
    {
        try
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Begin a database transaction
                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Get the unit price of the SKU (product)
                        decimal unitPrice = GetUnitPriceBySkuAndSize(sku, size);

                        // Calculate the total amount
                        decimal totalAmount = unitPrice * quantity;

                        // Insert order item
                        string insertOrderItemQuery = "INSERT INTO tb_order_items (order_id, quantity, sku, unit_price) " +
                                                      "VALUES (@OrderId, @Quantity, @Sku, @UnitPrice); SELECT LAST_INSERT_ID();";
                        MySqlCommand insertOrderItemCommand = new MySqlCommand(insertOrderItemQuery, connection, transaction);

                        insertOrderItemCommand.Parameters.AddWithValue("@OrderId", orderId);
                        insertOrderItemCommand.Parameters.AddWithValue("@Quantity", quantity);
                        insertOrderItemCommand.Parameters.AddWithValue("@Sku", sku);
                        insertOrderItemCommand.Parameters.AddWithValue("@UnitPrice", totalAmount);

                        // Execute the query and retrieve the generated order item ID
                        int orderItemId = Convert.ToInt32(insertOrderItemCommand.ExecuteScalar());

                        // Commit the transaction if everything is successful
                        transaction.Commit();

                        return orderItemId;
                    }
                    catch (Exception ex)
                    {
                        // Rollback the transaction on failure
                        transaction.Rollback();
                        Console.WriteLine(ex.Message);
                        return -1;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error opening connection: {ex.Message}");
            return -1; // Indicate failure
        }
    }

    // Helper method to get unit price by SKU
    public decimal GetUnitPriceBySkuAndSize(string sku, string size)
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            try
            {
                string getPriceBySkuAndSizeQuery;

                if (size == null)
                {
                    // If size is null, select the price based on SKU only
                    getPriceBySkuAndSizeQuery = "SELECT unit_price FROM tb_product_prices WHERE sku = @Sku AND size_name IS NULL";
                }
                else
                {
                    // Select the price based on SKU and the specified size
                    getPriceBySkuAndSizeQuery = "SELECT unit_price FROM tb_product_prices WHERE sku = @Sku AND size_name = @Size";
                }

                MySqlCommand getPriceBySkuAndSizeCommand = new MySqlCommand(getPriceBySkuAndSizeQuery, connection);

                getPriceBySkuAndSizeCommand.Parameters.AddWithValue("@Sku", sku);

                // Add the parameter for size only if it's not null
                if (size != null)
                {
                    getPriceBySkuAndSizeCommand.Parameters.AddWithValue("@Size", size);
                }

                using (MySqlDataReader reader = getPriceBySkuAndSizeCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Assuming "unit_price" is a decimal column in your database
                        decimal unitPrice = reader.GetDecimal(0);
                        return unitPrice;
                    }
                    else
                    {
                        // Handle the case when no records are found
                        return -1; // or throw an exception or return another appropriate value
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine(ex.Message);
                return -1; // or throw an exception or return another appropriate value
            }
        }
    }

    public bool insertOrderItemSpecifications(int orderItemId, string size, string design, string material, string note)
    {
        try
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Begin a database transaction
                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Insert order item specifications
                        string insertOrderItemSpecQuery = "INSERT INTO tb_order_items_specification (order_item_id, size, design, material, customer_note) " +
                                                          "VALUES (@OrderItemId, @Size, @Design, @Material, @Note)";
                        MySqlCommand insertOrderItemSpecCommand = new MySqlCommand(insertOrderItemSpecQuery, connection, transaction);

                        insertOrderItemSpecCommand.Parameters.AddWithValue("@OrderItemId", orderItemId);
                        insertOrderItemSpecCommand.Parameters.AddWithValue("@Size", size);
                        insertOrderItemSpecCommand.Parameters.AddWithValue("@Design", design);
                        insertOrderItemSpecCommand.Parameters.AddWithValue("@Material", material);
                        insertOrderItemSpecCommand.Parameters.AddWithValue("@Note", note);

                        int rowsAffectedSpec = insertOrderItemSpecCommand.ExecuteNonQuery();

                        // Commit the transaction if everything is successful
                        transaction.Commit();

                        return rowsAffectedSpec > 0;
                    }
                    catch (Exception ex)
                    {
                        // Rollback the transaction on failure
                        transaction.Rollback();
                        Console.WriteLine($"Error inserting order item specifications: {ex.Message}");
                        return false;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error opening connection: {ex.Message}");
            return false;
        }
    }
    public bool UpdateOrderTransactionAndAddPayment(int orderId, decimal totalPrice, string paymentMethod, bool isCustomerDesign)
    {
        try
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Add an additional charge of 150 if it's not a customer design
                        if (!isCustomerDesign)
                        {
                            totalPrice += 150m;
                        }

                        // Update the order transaction with the payment details
                        string updateOrderTransactionQuery = "UPDATE tb_order_transaction SET total_price = @TotalPrice, payment_method = @PaymentMethod, is_customer_design = @IsCustomerDesign WHERE order_id = @OrderId";
                        MySqlCommand updateOrderTransactionCommand = new MySqlCommand(updateOrderTransactionQuery, connection, transaction);

                        updateOrderTransactionCommand.Parameters.AddWithValue("@TotalPrice", totalPrice);
                        updateOrderTransactionCommand.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                        updateOrderTransactionCommand.Parameters.AddWithValue("@OrderId", orderId);
                        updateOrderTransactionCommand.Parameters.AddWithValue("@IsCustomerDesign", isCustomerDesign);

                        int rowsAffectedTransaction = updateOrderTransactionCommand.ExecuteNonQuery();

                        // Commit the transaction if everything is successful
                        transaction.Commit();

                        return rowsAffectedTransaction > 0;
                    }
                    catch (Exception ex)
                    {
                        // Rollback the transaction on failure
                        transaction.Rollback();
                        Console.WriteLine($"Error updating order transaction and adding payment: {ex.Message}");
                        return false;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error opening connection: {ex.Message}");
            return false;
        }
    }

}

