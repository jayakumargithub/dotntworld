using System.Web.Http;
using SecurityPipelineWthOwinHosting;

namespace SecurityPipelineWthOwinHosting
{
    [TestAuthenticationFilter]
     [TestAuthorizationFilter]
    public class TestController : ApiController
    {
        public IHttpActionResult Get()
        {
            Helper.Write("Controller", User);

            return Ok();
        }
    }
}