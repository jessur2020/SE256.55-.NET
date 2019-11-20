using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MovieList
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

             routes.MapRoute("Create", "Create", new { controller = "Movie", action = "Create" });
             routes.MapRoute("Edit", "Edit", new { controller = "Movie", action = "Edit" });
             routes.MapRoute("Details", "Details", new { controller = "Movie", action = "Details" });
             routes.MapRoute("Delete", "Delete", new { controller = "Movie", action = "Delete" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Movie", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
