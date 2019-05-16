using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_FinalProject
{      //set the format for routing here
    //
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            ///[Controller]/[ActionName]/[Parameters]
            routes.MapRoute( 
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            //to pass in parameters as route data than passing them as query strings. 
            routes.MapRoute(
          name: "Hello",
          url: "{controller}/{action}/{name}/{id}"
      );
        }
    }
}
// NOTE:The MapRoute method is used to route HTTP requests to the correct controller
 //and action method and supply the optional ID parameter. 