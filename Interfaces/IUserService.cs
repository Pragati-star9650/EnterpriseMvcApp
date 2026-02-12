using EnterpriseMvcApp.Models;
using System.Collections.Generic;

namespace EnterpriseMvcApp.Interfaces
{
    public interface IUserService
    {
        IEnumerable<User> GetUsers();
        User GetUser(int id);
        void CreateUser(User user);

        User? ValidateUser(string userName, string password);
    }
}

