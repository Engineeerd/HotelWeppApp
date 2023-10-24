using System.Web.Http;

namespace HotelWebApp.App_Start
{
    public class HWAConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // WEB API Routes.
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/v1/{controller}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}