using System.Collections.Generic;
using BlogBalta.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace BlogBalta.Repositories
{
    public class UserRepository
    {
        private SqlConnection _connection = new SqlConnection("");
        public IEnumerable<User> Get()
            => _connection.GetAll<User>();
        public User Get(int id)
            => _connection.Get<User>(id);
        public void Create(User user)
            => _connection.Insert<User>(user);
    }
}