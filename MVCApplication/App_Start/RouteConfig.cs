using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCApplication
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "ActionResults",
                url: "ActionResults/{action}",
                defaults: new {Controller= "ActionResults", action = "ViewResult"}
             );

            routes.MapRoute(
                name: "Student",
                url: "Student/{action}/{id}",
                defaults: new { controller = "Student", action = "StudentsList", id = UrlParameter.Optional }
            );

        }
    }
}
