using EnterpriseMvcApp.Models;
using System.Collections.Generic;

namespace EnterpriseMvcApp.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
        User GetById(int id);
        void Add(User user);
    }
}
