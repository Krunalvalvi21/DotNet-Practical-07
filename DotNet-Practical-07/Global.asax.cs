
using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DotNet_Practical_07
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
