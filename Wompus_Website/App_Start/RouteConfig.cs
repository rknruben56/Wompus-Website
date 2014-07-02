using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Wompus_Website
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            /* Following Custom Routes not Used */
            //News Route
            routes.MapRoute(
                name: "News",
                url: "News/{id}/{slug}",
                defaults: new { controller = "NewsController", action = "Details", slug = UrlParameter.Optional },
                constraints: new { id = @"\d+" });

            //Shows Route
            routes.MapRoute(
                name: "Shows",
                url: "Shows/{id}/{slug}",
                defaults: new { controller = "ShowsController", action = "Details", slug = UrlParameter.Optional },
                constraints: new { id = @"\d+" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}