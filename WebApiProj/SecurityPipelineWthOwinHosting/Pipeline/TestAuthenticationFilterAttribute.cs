using System;
using System.Threading.Tasks;
using System.Web.Http.Filters;

namespace SecurityPipelineWthOwinHosting
{
    public class TestAuthenticationFilterAttribute : Attribute, IAuthenticationFilter
    {
        public async Task AuthenticateAsync(HttpAuthenticationContext context, System.Threading.CancellationToken cancellationToken)
        {
            Helper.Write("AuthenticationFilter", context.ActionContext.RequestContext.Principal);
        }

        public async Task ChallengeAsync(HttpAuthenticationChallengeContext context, System.Threading.CancellationToken cancellationToken)
        {
            //throw new NotImplementedException();
        }

        public bool AllowMultiple
        {
            get { return false; }
        }
    }
}