using System;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;
using Security;

[assembly: OwinStartup(typeof(WebApiToken.Startup))]

namespace WebApiToken
{

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888

            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
            var myAuthorisationProvider = new MyAuthorisationServiceProvider();
            OAuthAuthorizationServerOptions options = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(1),
                Provider = myAuthorisationProvider
            };

           

            app.UseOAuthAuthorizationServer(options);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());

            HttpConfiguration config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                name:"Defaultapi",
                routeTemplate:"api/controller/{id}",
                defaults: new { id = RouteParameter.Optional}
            );

           
            WebApiConfig.Register(config);

        }
    }
}
