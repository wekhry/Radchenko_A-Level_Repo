using Api.Models;

namespace Api.Repositories
{
    public class UserRepository
    {
        private readonly List<User> _users;

        public UserRepository()
        {
            _users = new List<User>
            {
                new User { Id = 1, Name = "first", Email = "first@gmail.com"},
                new User { Id = 2, Name = "second", Email = "second@gmail.com"},
                new User { Id = 3, Name = "third", Email = "third@gmail.com"},
                new User { Id = 4, Name = "fourth", Email = "fourth@gmail.com"},
                new User { Id = 5, Name = "fifth", Email = "fifth@gmail.com"},
                new User { Id = 6, Name = "sixth", Email = "sixth@gmail.com"},
                new User { Id = 7, Name = "seventh", Email = "seventh@gmail.com"}
            };
        }

        public List<User> GetUsers()
        {
            return _users;
        }
        public User GetUserById(int id)
        { 
            return _users.FirstOrDefault(u => u.Id == id);
        }

        public User CreateUser(User user)
        {
            int newId = _users.Max(u => u.Id) + 1;

            user.Id = newId;

            _users.Add(user);

            return user;
        }

        public User UpdateUser(int id, User user)
        {
            User existingUser = _users.FirstOrDefault(u => u.Id == id);

            if(existingUser != null)
            {
                existingUser.Name = user.Name;
                existingUser.Email = user.Email;
            }

            return existingUser;
        }

        public User UpdateUserPartial(int id, User patchedUser)
        {
            User existingUser = _users.FirstOrDefault(u => u.Id == id);

            if(existingUser != null)
            {
                existingUser.Name = patchedUser.Name ?? existingUser.Name;
                existingUser.Email = patchedUser.Email ?? existingUser.Email;
            }

            return existingUser;
        }

        public bool DeleteUser(int id)
        {
            User user = _users.FirstOrDefault(u => u.Id == id);

            if(user != null)
            {
                _users.Remove(user);
                return true;
            }
            return false;
        }
    }
}
