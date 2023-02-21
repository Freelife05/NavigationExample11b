﻿using NavigationExample11b.Model;
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

        internal void CreateUser(User user)
        {
            using (NavigationDBEntities db = new NavigationDBEntities())
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

        internal List<User> ReadAllUsers()
        {
            using (NavigationDBEntities db = new NavigationDBEntities())
            {
                return db.Users.ToList();
            }
        }

        public void UpdateUser(int id, User user)
        {
            using (NavigationDBEntities db = new NavigationDBEntities())
            {
                var userToUpdate = db.Users.Where(u => u.Id == id).FirstOrDefault();
                if (userToUpdate != null)
                {
                    userToUpdate.Id = id;
                    userToUpdate.Username = user.Username;
                    userToUpdate.Password = user.Password;
                    db.SaveChanges();
                }
            }
        }

        public void DeleteUser(int id)
        {
            using (NavigationDBEntities db = new NavigationDBEntities())
            {
                var userToDelete = db.Users.Where(u => u.Id == id).FirstOrDefault();
                if (userToDelete != null)
                {
                    db.Users.Remove(userToDelete);
                    db.SaveChanges();
                }
            }
        }
    }
}
