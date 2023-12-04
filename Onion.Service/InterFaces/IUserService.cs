using Onion.Data.Account_CoupledClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Service.InterFaces
{
    public interface IUserService : IDisposable
    {
        User GetUserById(int userId);   
        void CreateUser(User user);
        void UpdateUser(User user);
        void DeleteUser(User user);
        void DeleteUser(int userId);

    }
}
