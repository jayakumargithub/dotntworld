using System.Web.Http;

namespace SecurityPipelineWthOwinHosting
{
    public class TestAuthorizationFilterAttribute : AuthorizeAttribute
    {
        protected override bool IsAuthorized(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            Helper.Write("AuthorizationFilter", actionContext.RequestContext.Principal);

            return true;
        }
    }
}