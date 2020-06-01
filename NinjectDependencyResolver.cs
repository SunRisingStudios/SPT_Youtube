using Ninject;
using SPTBusinessLayer.Interfaces;
using SPTBusinessLayer.Services;
using SPTDataLayer;
using SPTDataLayer.Database;
using SPTDataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPT.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private readonly IKernel _kernel;

        public NinjectDependencyResolver(IKernel kernel)
        {
            _kernel = kernel;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return _kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            _kernel.Bind<IEmployeeService>().To<EmployeeService>();
            _kernel.Bind<IUnitOfWork>().To<UnitOfWork>();
        }
    }
}