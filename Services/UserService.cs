using EnterpriseMvcApp.Interfaces;
using EnterpriseMvcApp.Models;
using EnterpriseMvcApp.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace EnterpriseMvcApp.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<User> GetUsers()
        {
            return _userRepository.GetAll();
        }

        public User GetUser(int id)
        {
            return _userRepository.GetById(id);
        }

        public void CreateUser(User user)
        {
            _userRepository.Add(user);
        }

        // 🔴 THIS METHOD WAS MISSING OR INCORRECT
        public User? ValidateUser(string userName, string password)
        {
            var user = _userRepository
                .GetAll()
                .FirstOrDefault(u => u.UserName == userName);

            if (user == null)
                return null;

            if (user.PasswordHash != password)
                return null;

            return user;
        }
    }
}
