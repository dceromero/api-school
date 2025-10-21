
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApiSchool
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de Web API
            // Habilitar CORS globalmente
            //var cors = new EnableCorsAttribute("http://localhost:4200/", "*", "GET,POST,PUT,DELETE");
            var cors = new EnableCorsAttribute("*", "*", "GET,POST,PUT,DELETE");
            // Parámetros: (orígenes permitidos, encabezados permitidos, métodos permitidos)
            config.EnableCors(cors);
            // Rutas de Web API
            config.MapHttpAttributeRoutes();


            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
