namespace SwankiNails2.utility
{
    public class EmailProvider
    {
        public readonly string _connectionString;

        public EmailProvider(string connectionString)
        {
            _connectionString = connectionString;
            // Use the connection string to initialize your database connection
        }

        // ... Implement your email-related methods or logic here
    }
}

