using System;
using System.Collections.Generic;

namespace SOLID.I.Violation
{
    public class ReadUser : IUser
    {
        public void Change(User user)
        {
        }

        public void Create(User user)
        {
        }

        public bool Delete(int id)
        {
            return false;
        }

        public List<User> GetAll()
        {
            Console.WriteLine("Listing all users");
            return new List<User>();
        }

        public User GetById(int id)
        {
            Console.WriteLine("Listing all users");
            return new User();
        }
    }
}
