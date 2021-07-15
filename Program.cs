using System;
using BlogBalta.Models;
using BlogBalta.Repositories;
using Dapper.Contrib.Extensions;
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
            ReadUsers(connection);
            ReadRoles(connection);
            //ReadUser();
            //CreateUser();
            //UpdateUser();
            connection.Close();
        }

        public static void ReadUsers(SqlConnection connection)
        {
            var repository = new Repository<User>(connection);
            var users = repository.Get();

            foreach (var user in users)
                Console.WriteLine(user.Name);

        }


        public static void ReadRoles(SqlConnection connection)
        {
            var repository = new Repository<Role>(connection);
            var roles = repository.Get();

            foreach (var role in roles)
                Console.WriteLine(role.Name);
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
