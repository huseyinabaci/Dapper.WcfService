using Ninject.Extensions.Wcf;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace Dapper.WcfService.Dependencies
{
    public class ServiceHostFactory : NinjectServiceHostFactory
    {
        protected override ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses)
        {
            var kernel = new StandardKernel(new NinjectDependency());
            var serviceInstance = kernel.Get(serviceType);
            return new ServiceHost(serviceInstance, baseAddresses);
        }
    }

}