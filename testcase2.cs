using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

public class SqlInjectionExample
{
    public void ExecuteQuery(string userInput)
    {
        // Input validation
        if (!Regex.IsMatch(userInput, @"^[a-zA-Z0-9]+$"))
        {
            throw new ArgumentException("Invalid input format.");
        }

        // Parameterized query to prevent SQL injection
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
