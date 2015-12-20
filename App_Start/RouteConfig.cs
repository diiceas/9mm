using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace razor_9mm
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
              "Audio",
              "audio",
              new { controller = "Default", action = "Audio" }
          );

            routes.MapRoute(
                "Video",
                "video",
                new { controller = "Default", action = "Video" }
            );

            routes.MapRoute(
                "Gallery",
                "gallery",
                new { controller = "Default", action = "Gallery" }
            );

            routes.MapRoute(
                "Info",
                "info",
                new { controller = "Default", action = "Info" }
            );

            routes.MapRoute(
                "News",
                "news",
                new { controller = "Default", action = "News" }
            );

            routes.MapRoute(
                "SendMessage",
                "sendMessage",
                new { controller = "Default", action = "SendMessage" }
            );

            routes.MapRoute(
                "Home",
                "Home",
                new { controller = "Default", action = "Index" }
            );

            routes.MapRoute(
                "Default",
                "{*catchall}",
                new { controller = "Default", action = "Index" }
            );
        }
    }
}