using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace conseat
{
    internal class DBConnection
    {
        private MySqlConnection connection;

        // Constructor that sets up the connection string
        public DBConnection()
        {
            // XAMPP default: server = localhost, user = root, no password
            string connectionString = "server=localhost;user id=root;password=;database=concertdb;AllowLoadLocalInfile=true;default command timeout=600;Max Pool Size=100;";

            connection = new MySqlConnection(connectionString);
        }

        // Method to get the connection
        public MySqlConnection GetConnection()
        {
            return connection;
        }

        // Optional: method to open connection safely
        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        // Optional: method to close connection safely
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}