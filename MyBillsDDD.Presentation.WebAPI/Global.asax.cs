
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MyBillsDDD.Presentation.WebAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //var container = new Container();

            //container.Options.DefaultScopedLifestyle = new WebApiRequestLifestyle();

            //container.Register<IBillService, BillService>(Lifestyle.Scoped);
            //container.Register<IBillAppService, BillAppService>(Lifestyle.Scoped);
            //container.Register<IBillRepository, BillRepository>(Lifestyle.Scoped);


        }
    }
}
