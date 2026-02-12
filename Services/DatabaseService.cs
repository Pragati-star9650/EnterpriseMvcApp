using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace EnterpriseMvcApp.Services
{
    public class DatabaseService
    {
        public List<string> GetDatabases(string serverName)
        {
            var databases = new List<string>();

            var connectionString =
                $"Server={serverName};Trusted_Connection=True;TrustServerCertificate=True;";

            using var connection = new SqlConnection(connectionString);
            connection.Open();

            var command = new SqlCommand(
                "SELECT name FROM sys.databases WHERE database_id > 4",
                connection);

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                databases.Add(reader.GetString(0));
            }

            return databases;
        }
    }
}
