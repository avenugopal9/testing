using System;
using System.Data.SqlClient;

public class SqlInjectionExample
{
    public void ExecuteQuery(string userInput)
    {
        // GOOD: Parameterized query to prevent SQL injection
        string query = "SELECT * FROM Users WHERE Name = @userInput";
        using (SqlConnection connection = new SqlConnection("connection_string"))
        {
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@userInput", userInput);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            // Process data
        }
    }
}

