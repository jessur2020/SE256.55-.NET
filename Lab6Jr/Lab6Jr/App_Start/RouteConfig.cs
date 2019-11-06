﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Lab6Jr
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(" Contact", "Contact", new { controller = "Home", action = "Contact" });
            routes.MapRoute(" About", "About", new { controller = "Home", action = "About" });
            routes.MapRoute(" Register", "Register", new { controller = "Account", action = "Register" });
            routes.MapRoute(" Login", "Login", new { controller = "Account", action = "Login" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
