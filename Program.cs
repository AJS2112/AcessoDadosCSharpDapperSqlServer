using System;
using BlogBalta.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace BlogBalta
{
    class Program
    {
        private const string CONNECTION_STRING = "Data source=localhost; Initial Catalog=BlogBalta; Persist Security Info=True; Integrated Security=SSPI;";
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static void ReadUsers()
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                var users = connection.GetAll<User>();
                foreach (var user in users)
                {
                    Console.WriteLine(user.Name);
                }
            }
        }
    }
}
