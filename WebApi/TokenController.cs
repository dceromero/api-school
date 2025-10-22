using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiSchool.WebApi
{
    [Authorize]
    [RoutePrefix("api/token")]
    public class TokenController : ApiController
    {
        [HttpGet]
        [Route("check-status")]
        public HttpResponseMessage checkStatus()
        {
            
            return Request.CreateResponse(HttpStatusCode.OK, true);
        }
    }
}
