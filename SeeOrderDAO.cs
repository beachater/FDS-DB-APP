﻿using FDS_application.UserControls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FDS_application.ItemGetDAO;

namespace FDS_application
{
  
    public class SeeOrderDAO
    {
        private static SeeOrderDAO instance;
        private string username;
        private string password;
        private string connectionString;

        public void setUser(string username, string password)
        {
            this.username = username;
            this.password = password;
            // Assuming MySQL connection for the given example
            this.connectionString = $"datasource=localhost;port=3307;username={this.username};password={this.password};database=db_infinytarwerks";
        }
        public static SeeOrderDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SeeOrderDAO();
                }
                return instance;
            }
        }
        public bool TestConnection()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    return true;
                }
            }
            catch (Exception)
            {
                // Handle exception if connection fails
                return false;
            }
        }
        public class SeeOrder
        {
            public string Recipient { get; set; }
            public string PhoneN0 { get; set; }
            public int OrderID { get; set; }
            public DateTime Date { get; set; }
            public decimal TotalPrice { get; set; }
            public string Org { get; set; }
            //public OrderStatus Status { get; set; }
        }

        public enum DesignRequirements
        {
            photoshop,
            corel,
            illustrator
        }
        public class SeeSupplyOrdered 
        {
            public int SupplyID { get; set; }
            public int Quantity { get; set; } 
            public decimal Amount { get; set; }
            public DateTime Date { get; set; }
            public string Product {  get; set; }
        }



        public class SeeOrderItem
        {
            public int ItemID { get; set; }
            public string Name { get; set; }
            public DesignRequirements Tools { get; set; }
            public string Category { get; set; }
            public int Quantity { get; set; }
            public string Design { get; set; }
            public string Size { get; set; }
            public string Material { get; set; }
            public string Note { get; set; }

        }
        public List<SeeOrder> GetOrders()
        {
            List<SeeOrder> returnThese = new List<SeeOrder>();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Delete order items specification first
                    string deleteOrderItemsSpecQuery = @"
                DELETE ois
                FROM tb_order_items_specification ois
                JOIN tb_order_items oi ON ois.order_item_id = oi.order_item_id
                WHERE oi.order_id IN (SELECT order_id FROM tb_order_transaction WHERE total_price IS NULL OR total_price = 0)
            ";

                    using (MySqlCommand deleteOrderItemsSpecCommand = new MySqlCommand(deleteOrderItemsSpecQuery, connection))
                    {
                        deleteOrderItemsSpecCommand.ExecuteNonQuery();
                    }

                    // Delete order items
                    string deleteOrderItemsQuery = @"
                DELETE oi
                FROM tb_order_items oi
                WHERE oi.order_id IN (SELECT order_id FROM tb_order_transaction WHERE total_price IS NULL OR total_price = 0)
            ";

                    using (MySqlCommand deleteOrderItemsCommand = new MySqlCommand(deleteOrderItemsQuery, connection))
                    {
                        deleteOrderItemsCommand.ExecuteNonQuery();
                    }

                    // Delete rows with total_price 0 or null in tb_order_transaction
                    string deleteOrderTransactionQuery = "DELETE FROM tb_order_transaction WHERE total_price IS NULL OR total_price = 0";
                    using (MySqlCommand deleteOrderTransactionCommand = new MySqlCommand(deleteOrderTransactionQuery, connection))
                    {
                        deleteOrderTransactionCommand.ExecuteNonQuery();
                    }

                    // Retrieve the orders after deletion
                    string query = @"
                SELECT
                    o.order_id,
                    o.order_date,
                    o.total_price,
                    o.status,
                    c.first_name,
                    c.last_name,
                    GROUP_CONCAT(DISTINCT cpn.phone_no ORDER BY cpn.phone_num_id DESC) AS phone_no,
                    co.org_name  -- Display organization name associated with org_id
                FROM
                    tb_order_transaction o
                JOIN tb_customers c ON o.customer_id = c.customer_id
                LEFT JOIN tb_cust_organization co ON o.org_id = co.org_id
                LEFT JOIN tb_cust_phone_num cpn ON c.customer_id = cpn.customer_id
                WHERE
                    o.status != 'finished'
                GROUP BY
                    o.order_id, o.order_date, o.total_price, o.status, c.first_name, c.last_name, co.org_id;
            ";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                SeeOrder order = new SeeOrder
                                {
                                    OrderID = Convert.ToInt32(reader["order_id"]),
                                    Date = reader["order_date"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(reader["order_date"]),
                                    TotalPrice = reader["total_price"] == DBNull.Value ? 0m : Convert.ToDecimal(reader["total_price"]),
                                    Recipient = $"{reader["first_name"]} {reader["last_name"]}",
                                    PhoneN0 = reader["phone_no"] == DBNull.Value ? string.Empty : reader["phone_no"].ToString(),
                                    Org = reader["org_name"] == DBNull.Value ? string.Empty : reader["org_name"].ToString()
                                };

                                System.Diagnostics.Debug.WriteLine($"OrderID: {order.OrderID}, Recipient: {order.Recipient}, PhoneN0: {order.PhoneN0}, org: {order.Org}");

                                returnThese.Add(order);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting orders: {ex.Message}");
            }

            return returnThese;
        }
        public List<SeeOrderItem> GetOrderItems(int orderId)
        {
            List<SeeOrderItem> returnThese = new List<SeeOrderItem>();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT oi.order_item_id, p.product_name, oi.quantity, pc.category_name, pc.design_requirements, ois.size, ois.design, ois.material, ois.customer_note FROM tb_order_items oi JOIN tb_product p ON oi.sku = p.sku JOIN tb_product_categories pc ON p.category_id = pc.category_id LEFT JOIN tb_order_items_specification ois ON oi.order_item_id = ois.order_item_id WHERE oi.order_id = @OrderId";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@OrderId", orderId);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                SeeOrderItem item = new SeeOrderItem
                                {
                                    ItemID = Convert.ToInt32(reader["order_item_id"]),
                                    Name = reader["product_name"].ToString(),
                                    Quantity = Convert.ToInt32(reader["quantity"]),
                                    Design = reader["design"].ToString(),
                                    Size = reader["size"].ToString(),
                                    Material = reader["material"].ToString(),
                                    Note = reader["customer_note"].ToString(),
                                    // Assuming the SKU in tb_order_items corresponds to Category in SeeOrderItem
                                    Category = reader["category_name"].ToString(),
                                    // Example: Assuming DesignRequirements is based on SKU
                                    Tools = (DesignRequirements)Enum.Parse(typeof(DesignRequirements), reader["design_requirements"].ToString())
                                };

                                returnThese.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting order items: {ex.Message}");
            }

            return returnThese;
        }

        public List<string> GetProducts()
        {
            List<string> products = new List<string>();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand("SELECT product_name FROM `tb_product`;", connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                products.Add(reader.GetString(0));  // Assuming product_name is the first column
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle any MySQL-related errors gracefully
                Console.WriteLine("Error retrieving fabric types: " + ex.Message);
                throw;  // Rethrow the exception to propagate it back to the caller
            }

            return products;  // Ensure a value is always returned
        }
        public List<string> GetSupplierNames(string productName)
        {
            List<string> supplierNames = new List<string>();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                SELECT s.supplier_name
                FROM tb_suppliers s
                JOIN tb_product p ON s.category_id = p.category_id
                WHERE p.product_name = @ProductName;";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProductName", productName);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                supplierNames.Add(reader.GetString("supplier_name"));
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle any MySQL-related errors gracefully
                Console.WriteLine("Error retrieving supplier names: " + ex.Message);
                throw;  // Rethrow the exception to propagate it back to the caller
            }

            return supplierNames;
        }
        public List<SeeSupplyOrdered> GetSupplyOrders()
        {
            List<SeeSupplyOrdered> supplyOrders = new List<SeeSupplyOrdered>();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                    SELECT so.SOrder_ID, so.Quantity, so.Amount, so.Date_Ordered, p.product_name
                    FROM tb_supply_order so
                    JOIN tb_product p ON so.SKU = p.sku
                    WHERE so.In_stock = 0";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                SeeSupplyOrdered supplyOrder = new SeeSupplyOrdered
                                {
                                    SupplyID = Convert.ToInt32(reader["SOrder_ID"]),
                                    Quantity = Convert.ToInt32(reader["Quantity"]),
                                    Amount = Convert.ToDecimal(reader["Amount"]),
                                    Date = Convert.ToDateTime(reader["Date_Ordered"]),
                                    Product = reader["product_name"].ToString()
                                };

                                supplyOrders.Add(supplyOrder);
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle any MySQL-related errors gracefully
                Console.WriteLine("Error retrieving supply orders: " + ex.Message);
                throw;  // Rethrow the exception to propagate it back to the caller
            }

            return supplyOrders;
        }
    }



}