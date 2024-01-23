using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDS_application
{                               // text = username.txt
    internal class Order_SuppliesDAO
    {
        private static Order_SuppliesDAO instance;
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
        public static Order_SuppliesDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Order_SuppliesDAO();
                }
                return instance;
            }
        }
        public class OrderSupply
        {
            public string Product { get; set; }
            public string SKU { get; set; }
            public string Category { get; set; }
            public string Supplier { get; set; }
            public int Needed { get; set; }
        }
        public class SuppliesStock
        {
            public string Product { get; set; }
            public string SKU { get; set; }
            public string Category { get; set; }
            public int Stock { get; set; }
            public int Needed { get; set; }
        }

        public List<SuppliesStock> GetStock()
        {
            List<SuppliesStock> returnList = new List<SuppliesStock>();

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        SELECT
    p.product_name AS Product,
    p.sku AS SKU,
    pc.category_name AS Category,
    p.product_stocks AS Stock,
    GREATEST(SUM(COALESCE(oi.quantity, 0)) - p.product_stocks, 0) AS Needed
FROM
    tb_product p
JOIN tb_product_categories pc ON p.category_id = pc.category_id
LEFT JOIN tb_order_items oi ON oi.sku = p.sku
GROUP BY
    p.product_name, p.sku, pc.category_name, p.product_stocks;";

                    using (var command = new MySqlCommand(query, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SuppliesStock stock = new SuppliesStock
                            {
                                Product = reader["Product"].ToString(),
                                SKU = reader["SKU"].ToString(),
                                Category = reader["Category"].ToString(),
                                Stock = Convert.ToInt32(reader["Stock"]),
                                Needed = Convert.ToInt32(reader["Needed"])
                            };

                            returnList.Add(stock);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting supply stock: {ex.Message}");
            }

            return returnList;
        }
        public void InsertSupplyOrder(int quantity, decimal amount, string supplier, string sku)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        INSERT INTO tb_supply_order (Quantity, Amount, Supplier, Date_Ordered, SKU)
                        VALUES (@Quantity, @Amount, @Supplier, @DateOrdered, @SKU);";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Quantity", quantity);
                        command.Parameters.AddWithValue("@Amount", amount);
                        command.Parameters.AddWithValue("@Supplier", supplier);
                        command.Parameters.AddWithValue("@DateOrdered", DateTime.Now);
                        command.Parameters.AddWithValue("@SKU", sku);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error inserting supply order: " + ex.Message);
                throw;  // Rethrow the exception to propagate it back to the caller
            }
        }
        public string GetSku(string productName)
        {
            string sku = null;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT sku FROM tb_product WHERE product_name = @ProductName;";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProductName", productName);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            sku = result.ToString();
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error getting SKU: " + ex.Message);
                throw;  // Rethrow the exception to propagate it back to the caller
            }

            return sku;  // Return null if no SKU is found
        }
        public void UpdateInStockStatus(int supplyId, bool inStock, string sku)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                UPDATE tb_supply_order
                SET In_stock = @InStock
                WHERE SOrder_ID = @SupplyId;";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@InStock", inStock);
                        command.Parameters.AddWithValue("@SupplyId", supplyId);

                        command.ExecuteNonQuery();
                    }

                    // Update the product stock if necessary
                    if (inStock)
                    {
                        string updateStockQuery = @"
                    UPDATE tb_product
                    SET product_stocks = product_stocks + (SELECT Quantity FROM tb_supply_order WHERE SOrder_ID = @SupplyId)
                    WHERE sku = @SKU;";

                        using (MySqlCommand updateStockCommand = new MySqlCommand(updateStockQuery, connection))
                        {
                            updateStockCommand.Parameters.AddWithValue("@SupplyId", supplyId);
                            updateStockCommand.Parameters.AddWithValue("@SKU", sku);

                            updateStockCommand.ExecuteNonQuery();
                        }
                    }

                    Console.WriteLine($"Supply ID: {supplyId}, In Stock: {inStock}, SKU: {sku}");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error updating In_stock status: " + ex.Message);
                throw;  // Rethrow the exception to propagate it back to the caller
            }
        }
        public bool DeleteSupplyOrderItem(int sorderid)
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
                            string query = "DELETE FROM tb_supply_order WHERE SOrder_ID = @sorderid";

                            using (MySqlCommand command = new MySqlCommand(query, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@sorderid", sorderid);
                                int affectedRows = command.ExecuteNonQuery();

                                if (affectedRows > 0)
                                {
                                    Console.WriteLine($"Deleted supply order item with SOrder_ID: {sorderid}");
                                    transaction.Commit(); // Commit the transaction
                                    return true;
                                }
                                else
                                {
                                    Console.WriteLine($"No rows affected. Could not find supply order item with SOrder_ID: {sorderid}");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error executing DELETE query: {ex.Message}");
                            transaction.Rollback(); // Rollback the transaction in case of an exception
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting supply order item: {ex.Message}");
            }

            return false;
        }
    }

}
