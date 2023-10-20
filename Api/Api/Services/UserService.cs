using Api.Models;
using Api.Repositories;

namespace Api.Services
{
    public class UserService
    {
        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<User> GetUsers() 
        {
            return _userRepository.GetUsers();
        }

        public User GetUserById(int id)
        {
            return _userRepository.GetUserById(id);
        }

        public User CreateUser(User user)
        {
            return _userRepository.CreateUser(user);
        }

        public User UpdateUser(int id, User user)
        {
            return _userRepository.UpdateUser(id, user);
        }

        public User UpdateUserPartial(int id, User patchedUser)
        {
            return _userRepository.UpdateUserPartial(id, patchedUser);
        }

        public bool DeleteUser(int id)
        {
            return _userRepository.DeleteUser(id);
        }
    }
}
