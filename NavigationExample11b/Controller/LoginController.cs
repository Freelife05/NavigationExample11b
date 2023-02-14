using NavigationExample11b.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationExample11b.Controller
{
    internal class LoginController
    {
        
       internal void AddUser(User user)
        {
            using(NavigationDBEntities db = new NavigationDBEntities())
            {
                var lastUser = db.Users.ToList().LastOrDefault();
                if (lastUser == null)
                {
                    user.Id = 1;
                }
                else
                {
                    user.Id = lastUser.Id + 1;
                }

                db.Users.Add(user);
                db.SaveChanges();
            }
        }

        internal List<User> GetAll()
        {
            using(NavigationDBEntities db = new NavigationDBEntities())
            {
                return db.Users.ToList();
            }
        }

        public  void UpdtaeUser(int id, User user)
        {
            using (NavigationDBEntities db = new NavigationDBEntities())
            {

            }
        }
        
    }
}
