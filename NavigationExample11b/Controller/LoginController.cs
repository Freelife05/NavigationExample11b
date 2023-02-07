using NavigationExample11b.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationExample11b.Controller
{
    internal static class LoginController
    {
        
        static List<User> users = new List<User>()
        {
           new User("Pesho", "12345"),
           new User("Admin", "admin123")
        };
           
        
        internal static void AddUser(User user)
        {
            users.Add(user);
        }

        internal static List<User> GetAll()
        {
            return users;
        }
        
    }
}
