using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FDS_application.SeeOrderDAO;

namespace FDS_application
{
    internal class OrderHistoryDAO
    {
        private static OrderHistoryDAO instance;
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
        public static OrderHistoryDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderHistoryDAO();
                }
                return instance;
            }
        }
        public class SeeOrderHistory
        {
            public string Recipient { get; set; }
            public string PhoneN0 { get; set; }
            public int OrderID { get; set; }
            public DateTime Date { get; set; }
            public decimal TotalPrice { get; set; }
            public string Org { get; set; }

        }
        public class SeeOrderHistoryItem
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
        public List<SeeOrderHistory> GetOrderHistory()
        {
            List<SeeOrderHistory> returnThese = new List<SeeOrderHistory>();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

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
                    o.status = 'finished'
                GROUP BY
                    o.order_id, o.order_date, o.total_price, o.status, c.first_name, c.last_name, co.org_id;";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                SeeOrderHistory orderH = new SeeOrderHistory
                                {
                                    OrderID = Convert.ToInt32(reader["order_id"]),
                                    Date = reader["order_date"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(reader["order_date"]),
                                    TotalPrice = reader["total_price"] == DBNull.Value ? 0m : Convert.ToDecimal(reader["total_price"]),
                                    Recipient = $"{reader["first_name"]} {reader["last_name"]}",
                                    PhoneN0 = reader["phone_no"] == DBNull.Value ? string.Empty : reader["phone_no"].ToString(),
                                    Org = reader["org_name"] == DBNull.Value ? string.Empty : reader["org_name"].ToString()  // Use the org_names column
                                };

                                System.Diagnostics.Debug.WriteLine($"OrderID: {orderH.OrderID}, Recipient: {orderH.Recipient}, PhoneN0: {orderH.PhoneN0}, Org: {orderH.Org}");

                                returnThese.Add(orderH);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting order history: {ex.Message}");
            }

            return returnThese;
        }

    }
}
