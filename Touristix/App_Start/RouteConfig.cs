﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Touristix
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            /*routes.MapRoute(
                "Accueil",
                "",
                new { controller = "Acceuil", action = "Index", UrlParameter.Optional }
                );*/

            routes.MapRoute(
                name: "Accueil",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Accueil", action = "Index", id = UrlParameter.Optional }
            );

            /*routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );*/
        }
    }
}