using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();
            //Debe ser definida desde la mas especifica a la mas generica
            //routes.MapRoute(
            //    "MoviesByReleaseDate",
            //    "movies/released/{year}/{month}",
            //    new { Controller = "Movie", Action = "ByReleaseDate"},
            //    //new { year = @"\d{4}", month = @"\d{2}"} // Limita el año a 4 digitos y el mes a 2
            //    new { year = @"2015|2016", month = @"\d{2}" } //limita el año a 2015 o 2016 
            //    );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
