using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FDS_application;


namespace FDS_application
{
    public class ItemGetDAO
    {
        private string connectionString = "datasource=localhost;port=3307;username=staff;password=staff123;database=db_infinytarwerks";
        private int orderId;
        public event EventHandler DataChanged;
        public void SetOrderId(int orderId)
        {
            this.orderId = orderId;
        }
        public void RaiseDataChanged()
        {
            DataChanged?.Invoke(this, EventArgs.Empty);
        }
        public class TotalItemList
        {
            public string Name { get; set; }
            public int Quant { get; set; }
            public int Price { get; set; }
            public int ID { get; set; }
        }
        public List<TotalItemList> GetItems()
        {
            List<TotalItemList> returnThese = new List<TotalItemList>();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT oi. order_item_id, oi.quantity, oi.unit_price, p.product_name " +
                                   "FROM tb_order_items oi " +
                                   "JOIN tb_product p ON oi.sku = p.sku " +
                                   "WHERE oi.order_id = @OrderID";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@OrderID", orderId);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TotalItemList item = new TotalItemList
                                {
                                    Name = reader["product_name"].ToString(),  // Use product_name instead of SKU
                                    Quant = Convert.ToInt32(reader["quantity"]),
                                    Price = Convert.ToInt32(reader["unit_price"]),
                                    ID = Convert.ToInt32(reader["order_item_id"])
                                };
                                returnThese.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting items: {ex.Message}");
            }

            return returnThese;
        }
        public void DeleteOrderItemSpecifications(int orderItemId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Start a transaction
                    using (MySqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Delete from child table
                            string childQuery = "DELETE FROM tb_order_items_specification WHERE order_item_id = @OrderItemId";
                            using (MySqlCommand childCommand = new MySqlCommand(childQuery, connection, transaction))
                            {
                                childCommand.Parameters.AddWithValue("@OrderItemId", orderItemId);
                                childCommand.ExecuteNonQuery();
                            }

                            // Delete from parent table
                            string parentQuery = "DELETE FROM tb_order_items WHERE order_item_id = @OrderItemId";
                            using (MySqlCommand parentCommand = new MySqlCommand(parentQuery, connection, transaction))
                            {
                                parentCommand.Parameters.AddWithValue("@OrderItemId", orderItemId);
                                parentCommand.ExecuteNonQuery();
                            }

                            // Commit the transaction if everything is successful
                            transaction.Commit();
                            
                        }
                        catch (Exception ex)
                        {
                            // Rollback the transaction if an error occurs
                            transaction.Rollback();
                            Console.WriteLine($"Error deleting order item: {ex.Message}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting order item: {ex.Message}");
            }
        }
        public void DeleteOrderItem(int orderItemId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Start a transaction
                    using (MySqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                                                      // Delete from parent table
                            string parentQuery = "DELETE FROM tb_order_items WHERE order_item_id = @OrderItemId";
                            using (MySqlCommand parentCommand = new MySqlCommand(parentQuery, connection, transaction))
                            {
                                parentCommand.Parameters.AddWithValue("@OrderItemId", orderItemId);
                                parentCommand.ExecuteNonQuery();
                            }

                            // Commit the transaction if everything is successful
                            transaction.Commit();

                        }
                        catch (Exception ex)
                        {
                            // Rollback the transaction if an error occurs
                            transaction.Rollback();
                            Console.WriteLine($"Error deleting order item: {ex.Message}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting order item: {ex.Message}");
            }
        }
        public void DeleteOrderTransaction(int orderId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Start a transaction
                    using (MySqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Get order item IDs associated with the order ID
                            List<int> orderItemIds = GetOrderItemIds(orderId, connection, transaction);

                            if (orderItemIds.Count > 0)
                            {
                                // Delete from child table (order items specifications)
                                string childQuery = "DELETE FROM tb_order_items_specification WHERE order_item_id IN (" + string.Join(",", orderItemIds) + ")";
                                using (MySqlCommand childCommand = new MySqlCommand(childQuery, connection, transaction))
                                {
                                    childCommand.ExecuteNonQuery();
                                }

                                // Delete from parent table (order items)
                                string parentQuery = "DELETE FROM tb_order_items WHERE order_id = @OrderID";
                                using (MySqlCommand parentCommand = new MySqlCommand(parentQuery, connection, transaction))
                                {
                                    parentCommand.Parameters.AddWithValue("@OrderID", orderId);
                                    parentCommand.ExecuteNonQuery();
                                }
                            }

                            // Delete from grandparent table (order transaction)
                            string grandparentQuery = "DELETE FROM tb_order_transaction WHERE order_id = @OrderID";
                            using (MySqlCommand grandparentCommand = new MySqlCommand(grandparentQuery, connection, transaction))
                            {
                                grandparentCommand.Parameters.AddWithValue("@OrderID", orderId);
                                grandparentCommand.ExecuteNonQuery();
                            }

                            // Commit the transaction if everything is successful
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            // Rollback the transaction if an error occurs
                            transaction.Rollback();
                            Console.WriteLine($"Error deleting order transaction: {ex.Message}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting order transaction: {ex.Message}");
            }
        }

        private List<int> GetOrderItemIds(int orderId, MySqlConnection connection, MySqlTransaction transaction)
        {
            List<int> orderItemIds = new List<int>();
            try
            {
                string query = "SELECT order_item_id FROM tb_order_items WHERE order_id = @OrderID";
                using (MySqlCommand command = new MySqlCommand(query, connection, transaction))
                {
                    command.Parameters.AddWithValue("@OrderID", orderId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            orderItemIds.Add(Convert.ToInt32(reader["order_item_id"]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting order item IDs: {ex.Message}");
            }

            return orderItemIds;
        }
        public decimal GetSumOfUnitPrices(int order_id)
        {
            decimal sumOfUnitPrices = 0;
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT SUM(unit_price) AS totalUnitPrice FROM tb_order_items WHERE order_id = @OrderID";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@OrderID", order_id);

                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            sumOfUnitPrices = Convert.ToDecimal(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting sum of unit prices: {ex.Message}");
            }

            return sumOfUnitPrices;
        }

        public void UpdateOrderStatus(int orderId, string newStatus)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE tb_order_transaction SET status = @NewStatus WHERE order_id = @OrderID";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NewStatus", newStatus);
                        command.Parameters.AddWithValue("@OrderID", orderId);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine($"Order status updated successfully to: {newStatus}");
                        }
                        else
                        {
                            Console.WriteLine("No rows were updated. Order ID may not exist.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating order status: {ex.Message}");
            }
        }
        public string GetOrderStatus(int orderId)
        {
            string status = null;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT status FROM tb_order_transaction WHERE order_id = @OrderID";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@OrderID", orderId);

                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            status = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting order status: {ex.Message}");
            }

            return status;
        }
    }


}
