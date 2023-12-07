using Onion.Service.InterFaces;

namespace Onion_Architecture.Web.UOW
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
        IUserService UserService { get; }
        IRoleService RoleService { get; }
    }
}
