using System;
using System.Collections.Generic;

namespace SOLID.I.Violation
{
    public class UserAdm : IUser
    {
        public void Change(User user)
        {
            Console.WriteLine("Chaging user.");
        }

        public void Create(User user)
        {
            Console.WriteLine("Creating user.");
        }

        public bool Delete(int id)
        {
            Console.WriteLine("Deleting user.");

            return true;
        }

        public List<User> GetAll()
        {
            Console.WriteLine("Getting all users.");

            return new List<User>();
        }

        public User GetById(int id)
        {
            Console.WriteLine("Getting user by id.");

            return new User();'
        }
    }
}
