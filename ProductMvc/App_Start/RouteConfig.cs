﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ProductMvc
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                       name: "Info",
                       url: "Admin/{action}/{username}",
                       defaults: new { controller = "Account", action = "Info", username = UrlParameter.Optional }
                    );

            routes.MapRoute(
                       name: "LogOn",
                       url: "Admin/{action}/{id}",
                       defaults: new { controller = "Account", action = "LogOn", id = UrlParameter.Optional }
                    );
            routes.MapRoute(
                name: "Bill",
                url: "Bill/{roomId}",
                defaults: new { controller = "InOut", action = "Bill", roomId = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "InOut", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}