using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Proyecto
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Pais", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Departa",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Departamento", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Ciudad",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Ciudad", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
