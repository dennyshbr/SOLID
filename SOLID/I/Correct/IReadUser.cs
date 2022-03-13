using System.Collections.Generic;

namespace SOLID.I.Correct
{
    public interface IReadUser
    {
        User GetById(int id);

        List<User> GetAll();
    }
}
