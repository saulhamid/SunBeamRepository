using SunBeam.Service.Implementations;
using SunBeam.Service.Interfaces;
using System.Data.Entity.Core.Metadata.Edm;
using System.Web.Http;
using System.Web.Mvc;

namespace SunBeam.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
