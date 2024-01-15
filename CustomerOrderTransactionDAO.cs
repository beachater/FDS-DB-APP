using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDS_application
{
    internal class CustomerOrderTransactionDAO
    {
        private string connectionString = "datasource=localhost;port=3307;username=root;password=root;database=db_infinytarwerks";

        public List<string> GetFabricTypes()
        {
            List<string> fabricTypes = new List<string>();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand("SELECT product_name FROM db_infinytarwerks.tb_product WHERE category_id = 1", connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                fabricTypes.Add(reader.GetString(0));  // Assuming product_name is the first column
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

            return fabricTypes;  // Ensure a value is always returned
        }
        public List<string> GetGlassTypes()
        {
            List<string> glassTypes = new List<string>();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand("SELECT product_name FROM db_infinytarwerks.tb_product WHERE category_id = 3", connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                glassTypes.Add(reader.GetString(0));  // Assuming product_name is the first column
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle any MySQL-related errors gracefully
                Console.WriteLine("Error retrieving glass types: " + ex.Message);
                throw;  // Rethrow the exception to propagate it back to the caller
            }

            return glassTypes;  // Ensure a value is always returned
        }

    }
}
