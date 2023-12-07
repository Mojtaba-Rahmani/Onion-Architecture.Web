using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Ninject;
using Ninject.Modules;
using Onion.Data.Account_CoupledClass;
using Onion.Repositor.ApplicationContext;
using Onion.Repositor.DataTransfer;
using Onion.Service.Implementation;
using Onion.Service.InterFaces;
using Onion_Architecture.Web;
using Onion_Architecture.Web.UOW;
using ServiceStack;
using ServiceStack.Host;


namespace Onion_Architecture.Web.IOC
{
    public class NinjectController : IControllerActivator
    {
        private IKernel ninjectKernel;
        public NinjectController()
        {
            ninjectKernel = new StandardKernel();
            ninjectKernel.Bind<OnionContext>().To<OnionContext>();
            ninjectKernel.Bind<IUnitOfWork>().To<UnitOfWork>();
        }
        public object Create(ControllerContext context)
        {
            return ninjectKernel.Get(context.ActionDescriptor.ControllerTypeInfo.AsType());
        }

        public void Release(ControllerContext context, object controller)
        {
            if (controller is IDisposable disposableController)
            {
                disposableController.Dispose();
            }
        }
    }
}