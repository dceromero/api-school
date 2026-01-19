using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiSchool.WebApi
{
    [RoutePrefix("api/evaluacion")]
    [Authorize]
    public class EvaluacionController : ApiController
    {
        private readonly Services.EvaluacionService _evaluacionService;
        public EvaluacionController(Services.EvaluacionService evaluacionService)
        {
            _evaluacionService = evaluacionService;
        }
        [HttpGet]
        [Route("tipos")]
        public HttpResponseMessage GetTiposEvaluaciones()
        {
            var resultados = _evaluacionService.GetTiposEvaluaciones();
            return Request.CreateResponse(HttpStatusCode.OK,resultados);
        }
    }
}
