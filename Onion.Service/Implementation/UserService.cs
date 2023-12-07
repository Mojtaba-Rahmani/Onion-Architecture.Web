using Onion.Data.Account_CoupledClass;
using Onion.Repositor.DataTransfer;
using Onion.Service.InterFaces;
using Onion.Data.Access;

namespace Onion.Service.Implementation
{
    public class UserService : IUserService
    {
        private IRepository<User> _userRepository;

        public UserService(IRepository<User> _userRepository, Repository<UserRole> repository)
        {
            this._userRepository = _userRepository;
        }


        public User GetUserById(int userId)
        {
            //return _userRepository.Get(u => u.Id == userId).SingleOrDefault();
            // or
            return _userRepository.GetById(userId);
        }

        public void CreateUser(User user)
        {
           _userRepository.Insert(user);
        }

        public void UpdateUser(User user)
        {
            _userRepository.Update(user);
        }

        public void DeleteUser(User user)
        {
            UpdateUser(user);
        }

        public void DeleteUser(int userId)
        {
            var user = GetUserById(userId);

            user.IsDelete= true;
            UpdateUser(user);
        }

        #region Dispose
        public void Dispose()
        {
            _userRepository?.Dispose();
        }
        #endregion

    }
}
