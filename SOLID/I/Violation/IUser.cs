using System.Collections.Generic;

namespace SOLID.I.Violation
{
    public interface IUser
    {
        void Create(User user);

        void Change(User user);

        bool Delete(int id);

        User GetById(int id);

        List<User> GetAll();
    }
}
