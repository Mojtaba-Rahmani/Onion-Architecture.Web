using Microsoft.AspNetCore.Mvc;
using Onion.Data.Account_CoupledClass;
using Onion.Repositor.ApplicationContext;
using Onion.Repositor.DataTransfer;

namespace Onion_Architecture.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            
            // Get by UserName
            var repo = new Repository<User>(new OnionContext());
            repo.Get(r => r.UserName == "OnionTest");

            // Delete by Is Delete
            var user = new User();

            user.IsDelete = true;
            repo.Delete(user);

            return View();
        }
    }
}
