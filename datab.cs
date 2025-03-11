using MySql.Data.MySqlClient;
using System;


namespace OOP
{
    class Manageproduct
    {
        protected string connString;
        public class InsertNewProduct
        {
            private string server = "localhost";
            private string database = "csharpapp";
            private string username = "root";
            private string password = "";
            protected string connString = $"SERVER={server};DATABASE={database};UID={username};PASSWORD={password};";
            public InsertNewProduct()
            {
               
            }
            public void InsertData(string productName, string productDescription, int productPrice)
            {
                try
                {

                    using (MySqlConnection conn = new MySqlConnection(connString))
                    {
                        conn.Open();
                        Console.WriteLine("connected to database");
                        string query = $"INSERT INTO products(productName, productPrice, productDescription) VALUES (@name, @description, @price)";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@name", productName);
                            cmd.Parameters.AddWithValue("@description", productDescription);
                            cmd.Parameters.AddWithValue("@price", productPrice);
                            cmd.ExecuteNonQuery();

                            int rowsAffected = cmd.ExecuteNonQuery();

                            Console.WriteLine(rowsAffected > 0 ? @"data inserted successfully":"failed to insert data");

                        }
                    }
                    Console.WriteLine(@" ____  ____  _____  ____    _  _      ____  _____ ____  _____  _____ ____    ____  _     ____  ____  _____ ____  ____  _____ _     _     _    ___  _
/  _ \/  _ \/__ __\/  _ \  / \/ \  /|/ ___\/  __//  __\/__ __\/  __//  _ \  / ___\/ \ /\/   _\/   _\/  __// ___\/ ___\/    // \ /\/ \   / \   \  \//
| | \|| / \|  / \  | / \|  | || |\ |||    \|  \  |  \/|  / \  |  \  | | \|  |    \| | |||  /  |  /  |  \  |    \|    \|  __\| | ||| |   | |    \  / 
| |_/|| |-||  | |  | |-||  | || | \||\___ ||  /_ |    /  | |  |  /_ | |_/|  \___ || \_/||  \_ |  \_ |  /_ \___ |\___ || |   | \_/|| |_/\| |_/\ / /  
\____/\_/ \|  \_/  \_/ \|  \_/\_/  \|\____/\____\\_/\_\  \_/  \____\\____/  \____/\____/\____/\____/\____\\____/\____/\_/   \____/\____/\____//_/   
                                                                                                                                                    ");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("error " + ex.Message);
                }
            }
            public bool ValidateUser(string productName, string productDescription, int productPrice)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connString))
                    {
                        conn.Open();
                        string query = $"INSERT COUNT(*) FROM user WHERE (productName, productPrice, productDescription) VALUES (@name, @description, @price)";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@name", productName);
                            cmd.Parameters.AddWithValue("@description", productDescription);
                            cmd.Parameters.AddWithValue("@price", productPrice);
                            int count = Convert.ToInt32(cmd.ExecuteScalar());
                            return count > 0;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("error " + ex.Message);
                    return false;
                }
            }




            class Select : Manageproduct
            {
                public Select()
                {

                }
                public void SelectData()
                {
                    try
                    {
                        using (MySqlConnection conn = new MySqlConnection(connString))
                        {
                            conn.Open();
                            string query = "SELECT * FROM products";
                            using (MySqlCommand cmd = new MySqlCommand(query, conn))
                            {
                                using (MySqlDataReader reader = cmd.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        Console.WriteLine(reader["productName"].ToString());
                                        Console.WriteLine(reader["productDescription"].ToString());
                                        Console.WriteLine(reader["productPrice"].ToString());
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("error " + ex.Message);
                    }
                }
            }
        }
    }
}
