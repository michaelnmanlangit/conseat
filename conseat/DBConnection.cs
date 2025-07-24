using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace conseat
{
    // ABSTRACTION: Interface defining database operations contract
    public interface IDbConnection : IDisposable
    {
        MySqlConnection GetConnection();
        void OpenConnection();
        void CloseConnection();
        bool TestConnection();
    }

    // ENCAPSULATION: Internal implementation details hidden
    // INHERITANCE: Implements IDbConnection interface
    internal class DBConnection : IDbConnection
    {
        // ENCAPSULATION: Private fields protecting connection details
        private MySqlConnection _connection;
        private readonly string _connectionString;
        private bool _disposed = false;

        // ENCAPSULATION: Constructor encapsulates connection setup
        public DBConnection()
        {
            // ABSTRACTION: Complex connection string creation abstracted away
            _connectionString = BuildConnectionString();
            _connection = new MySqlConnection(_connectionString);
        }

        // POLYMORPHISM: Alternative constructor for different configurations
        public DBConnection(string server, string database, string userId, string password)
        {
            _connectionString = BuildConnectionString(server, database, userId, password);
            _connection = new MySqlConnection(_connectionString);
        }

        // ENCAPSULATION: Private method to build connection string
        private string BuildConnectionString(
            string server = "localhost", 
            string database = "concertdb", 
            string userId = "root", 
            string password = "")
        {
            return $"server={server};user id={userId};password={password};database={database};" +
                   "AllowLoadLocalInfile=true;default command timeout=600;Max Pool Size=100;";
        }

        // ABSTRACTION: Simple interface for getting connection
        public MySqlConnection GetConnection()
        {
            ValidateNotDisposed();
            return _connection;
        }

        // ENCAPSULATION: Safe connection opening with error handling
        public void OpenConnection()
        {
            ValidateNotDisposed();
            
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }
            }
            catch (MySqlException ex)
            {
                throw new DatabaseException($"Failed to open database connection: {ex.Message}", ex);
            }
        }

        // ENCAPSULATION: Safe connection closing
        public void CloseConnection()
        {
            try
            {
                if (_connection?.State == ConnectionState.Open)
                {
                    _connection.Close();
                }
            }
            catch (MySqlException ex)
            {
                // Log error but don't throw - closing should be safe
                System.Diagnostics.Debug.WriteLine($"Error closing connection: {ex.Message}");
            }
        }

        // ABSTRACTION: High-level method to test database connectivity
        public bool TestConnection()
        {
            try
            {
                using (var testConnection = new MySqlConnection(_connectionString))
                {
                    testConnection.Open();
                    return testConnection.State == ConnectionState.Open;
                }
            }
            catch
            {
                return false;
            }
        }

        // ENCAPSULATION: Private validation method
        private void ValidateNotDisposed()
        {
            if (_disposed)
                throw new ObjectDisposedException(nameof(DBConnection));
        }

        // POLYMORPHISM: Implementing IDisposable pattern
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // ENCAPSULATION: Protected dispose method for inheritance
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed && disposing)
            {
                CloseConnection();
                _connection?.Dispose();
                _disposed = true;
            }
        }

        // ABSTRACTION: Finalizer for cleanup
        ~DBConnection()
        {
            Dispose(false);
        }
    }

    // ABSTRACTION: Custom exception for database-related errors
    // INHERITANCE: Inherits from Exception
    public class DatabaseException : Exception
    {
        public DatabaseException(string message) : base(message) { }
        public DatabaseException(string message, Exception innerException) : base(message, innerException) { }
    }

    // ABSTRACTION: Static factory class for creating database connections
    // ENCAPSULATION: Hides complex creation logic
    public static class DatabaseFactory
    {
        // POLYMORPHISM: Different ways to create connections
        public static IDbConnection CreateConnection()
        {
            return new DBConnection();
        }

        public static IDbConnection CreateConnection(string server, string database, string userId, string password)
        {
            return new DBConnection(server, database, userId, password);
        }

        // ABSTRACTION: Method to create and test connection
        public static IDbConnection CreateAndTestConnection()
        {
            var connection = new DBConnection();
            if (!connection.TestConnection())
            {
                connection.Dispose();
                throw new DatabaseException("Unable to establish database connection");
            }
            return connection;
        }
    }
}