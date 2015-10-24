using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MobiShop.WebUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            routes.MapRoute(null, "", new
            {
                controller = "Home",
                action = "Index"
            });

            routes.MapRoute(null, "NSX-Dien-thoai-{ManufactureNameUnsign}", new
            {
                controller = "Product",
                action = "ListByManufacureId"
            });

            routes.MapRoute(null, "{id}/Dien-thoai-{ProductNameUnsign}", new
            {
                controller = "Product",
                action = "Details"
            });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}