using Microsoft.AspNetCore.Mvc;
using Onion.Data.Account_CoupledClass;
using Onion.Repositor.ApplicationContext;
using Onion.Repositor.DataTransfer;
using Onion.Service.InterFaces;
using Onion_Architecture.Web.UOW;

namespace Onion_Architecture.Web.Controllers
{
    public class HomeController : Controller
    {
        private IUnitOfWork _unitOfWork;
       
        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {

            //// Get by UserName
            //var repo = new Repository<User>(new OnionContext());
            //repo.Get(r => r.UserName == "OnionTest");

            //// Delete by Is Delete
            //var user = new User();

            //user.IsDelete = true;
            //repo.Delete(user);

            var user = _unitOfWork.UserService.GetUserById(1);

            var Role = _unitOfWork.RoleService.GetRoleById(1);

            return View();
        }
    }
}
