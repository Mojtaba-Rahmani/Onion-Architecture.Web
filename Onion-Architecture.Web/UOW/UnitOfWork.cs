using Onion.Data.Access;
using Onion.Data.Account_CoupledClass;
using Onion.Repositor.ApplicationContext;
using Onion.Repositor.DataTransfer;
using Onion.Service.Implementation;
using Onion.Service.InterFaces;

namespace Onion_Architecture.Web.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private OnionContext context;


        public UnitOfWork(OnionContext context)
        {
            this.context = context;
        }
        private IUserService _UserService;
        private IRoleService _RoleService;
        public IUserService UserService
        {
            get
            {
                if (_UserService == null)
                {
                    _UserService = new UserService(new Repository<User>(context), new Repository<UserRole>(context));
                }
                return _UserService;
            }
        }

        public IRoleService RoleService
        {
            get
            {
                if (_RoleService == null)
                {
                    _RoleService = new RoleService(new Repository<UserRole>(context));
                }
                return _RoleService;
            }
        }


        #region DisPose&Save
        public void Dispose()
        {
            context?.Dispose();
        }

        public void Save()
        {
            context.SaveChanges();
        }
        #endregion

    }
}
