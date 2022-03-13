using System;
using System.Collections.Generic;

namespace SOLID.I.Correct
{
    public class ReadUser : IReadUser
    {
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
