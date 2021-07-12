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
            //ReadUsers();
            //ReadUser();
            //CreateUser();
            UpdateUser();
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

        public static void ReadUser()
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                var user = connection.Get<User>(1);
                Console.WriteLine(user.Name);
            }
        }

        public static void CreateUser()
        {
            var user = new User()
            {
                Bio = "Batman",
                Email = "batman@gmail.com",
                Image = "https://",
                Name = "Batman",
                PasswordHash = "HASH",
                Slug = "batman"
            };
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Insert<User>(user);
                Console.WriteLine("Cadastro realizado con sucesso");
            }
        }

        public static void UpdateUser()
        {
            var user = new User()
            {
                Id = 2,
                Bio = "Batman The Hero",
                Email = "batman@gmail.com",
                Image = "https://",
                Name = "Batman",
                PasswordHash = "HASH",
                Slug = "batman"
            };
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Update<User>(user);
                Console.WriteLine("Atualização realizada con sucesso");
            }
        }

        public static void DeleteUser()
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                var user = connection.Get<User>(2);
                connection.Delete<User>(user);
                Console.WriteLine("Exclusão realizada con sucesso");
            }
        }
    }
}
