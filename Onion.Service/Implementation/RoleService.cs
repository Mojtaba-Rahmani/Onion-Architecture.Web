using Onion.Data.Access;
using Onion.Repositor.DataTransfer;
using Onion.Service.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Service.Implementation
{
    public class RoleService : IRoleService
    {
        private IRepository<UserRole> _userRoleRepository;

        public RoleService(IRepository<UserRole> userRoleRepository)
        {
            this._userRoleRepository = userRoleRepository;
        }

        public void CreateRole(UserRole userRole)
        {
             _userRoleRepository.Insert(userRole);
        }

        public void DeleteRole(UserRole userRole)
        {
            UpdateRole(userRole);
        }

        public void DeleteRole(int UserRoleId)
        {
            var UserRole = GetRoleById(UserRoleId);

            UserRole.IsDelete = true;
            UpdateRole(UserRole);
        }
        public UserRole GetRoleById(int userRoleId)
        {
            return _userRoleRepository.GetById(userRoleId);
        }

        public void UpdateRole(UserRole userRole)
        {
            _userRoleRepository.Update(userRole);
        }

        #region Dispose
        public void Dispose()
        {
            _userRoleRepository?.Dispose();
        }
        #endregion
    }
}
