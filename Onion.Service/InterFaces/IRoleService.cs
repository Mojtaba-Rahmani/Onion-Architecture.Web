using Onion.Data.Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Service.InterFaces
{
    public interface IRoleService : IDisposable
    {
        UserRole GetRoleById(int userRoleId);
        void CreateRole(UserRole userRole);
        void UpdateRole(UserRole userRole);
        void DeleteRole(UserRole userRole);
        void DeleteRole(int UserRoleId);

    }
}
