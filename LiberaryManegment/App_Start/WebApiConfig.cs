using System.Web.Http;

namespace LiberaryManegment
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // فقط فرمت JSON فعال می‌کنیم
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new System.Net.Http.Headers.MediaTypeHeaderValue("application/json"));

            // روت‌ها
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }


    }

}