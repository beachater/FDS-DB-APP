﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FDS_application
{
    public class ItemGetDAO
    {
        private string connectionString = "datasource=localhost;port=3307;username=root;password=root;database=db_infinytarwerks";
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
        public List<TotalItemList> GetItems()
        {
            List<TotalItemList> returnThese = new List<TotalItemList>();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT SKU, Quantity, unit_price FROM tb_order_items WHERE order_id = @OrderID";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@OrderID", orderId);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TotalItemList item = new TotalItemList
                                {
                                    SKU = reader["SKU"].ToString(),
                                    Quantity = Convert.ToInt32(reader["Quantity"]),
                                    unit_price = Convert.ToInt32(reader["unit_price"])
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
    }
}
