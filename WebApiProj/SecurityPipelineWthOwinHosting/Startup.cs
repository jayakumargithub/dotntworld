using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Owin;

namespace SecurityPipelineWthOwinHosting
{

    /*
     * WebApi 2 security from plural sight
     https://app.pluralsight.com/player?course=webapi-v2-security&author=dominick-baier&name=webapi-v2-security-m3-architecture&clip=8&mode=live
     
     Try changing the Project properties -> server > OwninHost or IISExpress
     
     */
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var configuration = new HttpConfiguration();
            configuration.Routes.MapHttpRoute("default", "api/{controller}");

         //  configuration.Filters.Add(new TestAuthenticationFilterAttribute());
            app.Use(typeof(TestMiddleware));
            app.UseWebApi(configuration);
          
        }
    }
}