using System;
using Microsoft.Data.SqlClient;

namespace BlogBalta
{
    class Program
    {
        private const string CONNECTION_STRING = "Data source=localhost; Initial Catalog=BlogBalta; Persist Security Info=True; Integrated Security=SSPI;";
        static void Main(string[] args)
        {
            var connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();

            connection.Close();
            Console.ReadKey();
        }

    }
}
