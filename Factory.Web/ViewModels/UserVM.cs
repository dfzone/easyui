using Factory.Web.Helper;
using Factory.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factory.Web.ViewModels
{
    public class UserVM
    {
        public IEnumerable<User> Search()
        {
            string sql = "SELECT * FROM [user];";
            var result = SqlHelper.DoSearch<User>(sql, null);
            return result;
        }

        public int Update(User user)
        {
            string sql = "UPDATE [user] SET firstname=@firstname,lastname=@lastname,email=@email,phone=@phone WHERE id=@id;";
            var result = SqlHelper.DoUpdate(sql, user);
            return result;
        }

        public int Delete(int id)
        {
            string sql = "DELETE [user] WHERE id=@id;";
            var result = SqlHelper.DoDelete(sql, id);
            return result;
        }

        public int Add(User user)
        {
            string sql = "INSERT [user](firstname, lastname,phone,email) VALUES(@firstname, @lastname,@phone,@email);";
            var result = SqlHelper.DoAdd(sql, user);
            return result;
        }
    }
}