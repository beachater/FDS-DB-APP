using FDS_application.UserControls;
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
        private string connectionString = "datasource=localhost;port=3307;username=root;password=root;database=db_infinytarwerks";
       /* public enum OrderStatus
    {
        pending,
        processing,
        finished

            // Add other status values as needed  Recipient = $"{reader["first_name"]} {reader["last_name"]}",
        }
       */

        public class SeeOrder
        {
            public string Recipient { get; set; }
            public string PhoneN0 { get; set; }
            public int OrderID { get; set; }
            public DateTime Date { get; set; }
            public decimal TotalPrice { get; set; }
            //public OrderStatus Status { get; set; }
        }

        public enum DesignRequirements
        {
            photoshop,
            corel,
            illustrator
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

                        string query = "SELECT o.order_id, o.order_date, o.total_price,o.status, c.first_name, c.last_name, c.phone_no FROM tb_order_transaction o JOIN tb_customers c ON o.customer_id = c.customer_id";

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
                                        //Status = (OrderStatus)Enum.Parse(typeof(OrderStatus), reader["status"].ToString()),
                                        Recipient = $"{reader["first_name"]} {reader["last_name"]}",
                                        PhoneN0 = reader["phone_no"] == DBNull.Value ? string.Empty : reader["phone_no"].ToString()
                                    };
                                   // Console.WriteLine($"OrderID: {order.OrderID}, CustomerID: {reader["customer_id"]}, Status: {order.Status}, Recipient: {order.Recipient}, PhoneN0: {order.PhoneN0}");
                                    System.Diagnostics.Debug.WriteLine($"OrderID: {order.OrderID}, Recipient: {order.Recipient}, PhoneN0: {order.PhoneN0}");

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

                    string query = "SELECT oi.order_item_id, p.product_name, oi.quantity, pc.category_name, p.design_requirements, ois.size, ois.design, ois.material, ois.customer_note FROM tb_order_items oi JOIN tb_product p ON oi.sku = p.sku JOIN tb_product_categories pc ON p.category_id = pc.category_id LEFT JOIN tb_order_items_specification ois ON oi.order_item_id = ois.order_item_id WHERE oi.order_id = @OrderId";

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
    }

    }