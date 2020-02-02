using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EjemploRouting
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();
            routes.MapRoute(
                name: "Custom",
                url: "{controller}/{action}/{id}/{raza}",
                defaults: new { controller = "Home", action = "Animal", id = UrlParameter.Optional, raza = UrlParameter.Optional },
                constraints: new { controller = "Home", action = "Animal", id = "Perro", raza = "^B.*" }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
