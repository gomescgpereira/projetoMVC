[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(GomesMVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(GomesMVC.App_Start.NinjectWebCommon), "Stop")]

namespace GomesMVC.App_Start
{
    using System;
    using System.Web;
   
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;
    using Gomes.Repository;

    using Ninject;
    using Ninject.Web.Common;
    using Gomes.Application.Interface.Common;
    using Gomes.Application;
    using Gomes.Application.Interface;
    using Gomes.Domain.Interfaces.Service;
    using Gomes.Domain.Service;
    using Gomes.Domain.Interfaces.Repository;
    using Gomes.Domain.Interfaces.Repository.Common;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
           

            kernel.Bind(typeof(IApplicationServiceBase<>)).To(typeof(AppServiceBase<>));
            kernel.Bind<IClienteApplicationService>().To<ClientAppService>();

            kernel.Bind(typeof(IServiceBase<>)).To(typeof(IServiceBase<>));
            kernel.Bind<IClienteService>().To<ClienteService>();

            kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            kernel.Bind<IClienteRepository>().To<ClienteRepository>();
        }        
    }
}
