using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Lab01_MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Calculation",
                url: "Calculation/{action}/{Message}",
                defaults: new { controller = "Calculation", action = "Index", Message = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Calculations",
                url: "Calculation/{Message}",
                defaults: new { controller = "Calculation", action = "Math", Message = UrlParameter.Optional }
            );

          
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{Message}",
                defaults: new { controller = "Calculation", action = "Index", Message = UrlParameter.Optional }
            );
        }
    }
}
