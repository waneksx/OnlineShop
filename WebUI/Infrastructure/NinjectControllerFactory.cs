using DomainModel.Abstract;
using DomainModel.Concrete;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebUI.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;

        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBinding();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null: (IController)ninjectKernel.Get(controllerType);
        }

        private void AddBinding()
        {
            ninjectKernel.Bind<ISongRepo>().To<EFSongRepository>();
        }
    }
}