using System;
using System.Data.SqlClient;

public class SqlInjectionExample
{
    public void ExecuteQuery(string userInput)
    {
        // BAD: Unvalidated input concatenated into a SQL query
        string query = "SELECT * FROM Users WHERE Name = '" + userInput + "'";
        using (SqlConnection connection = new SqlConnection("connection_string"))
        {
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            // Process data
        }
    }
}
