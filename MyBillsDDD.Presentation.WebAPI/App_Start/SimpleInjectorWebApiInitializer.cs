[assembly: WebActivator.PostApplicationStartMethod(typeof(MyBillsDDD.Presentation.WebAPI.App_Start.SimpleInjectorWebApiInitializer), "Initialize")]

namespace MyBillsDDD.Presentation.WebAPI.App_Start
{
    using System.Web.Http;
    using SimpleInjector;
    using SimpleInjector.Integration.WebApi;
    using Application.Interfaces;
    using Application.Applications;
    using Domain.Services;
    using Domain.Repositories;
    using infra.Repositories;

    public static class SimpleInjectorWebApiInitializer
    {
        /// <summary>Initialize the container and register it as Web API Dependency Resolver.</summary>
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebApiRequestLifestyle();
            
            InitializeContainer(container);

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);
       
            container.Verify();
            
            GlobalConfiguration.Configuration.DependencyResolver =
                new SimpleInjectorWebApiDependencyResolver(container);
        }
     
        private static void InitializeContainer(Container container)
        {

            container.Register<IBillService, BillService>(Lifestyle.Scoped);
            container.Register<IBillAppService, BillAppService>(Lifestyle.Scoped);
            container.Register<IBillRepository, BillRepository>(Lifestyle.Scoped);

            // For instance:
            // container.Register<IUserRepository, SqlUserRepository>(Lifestyle.Scoped);
        }
    }
}