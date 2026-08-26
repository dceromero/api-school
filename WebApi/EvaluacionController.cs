using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiSchool.Requests;

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
        [Route("tipos-evaluacion")]
        public HttpResponseMessage GetTiposEvaluaciones()
        {
            var resultados = _evaluacionService.GetTiposEvaluaciones();
            return Request.CreateResponse(HttpStatusCode.OK, resultados);
        }

        [HttpGet]
        [Route("get-evalaciones-by-id-logro")]
        public HttpResponseMessage GetEvaluacionesByIdLogro(int id)
        {
            var resultados = _evaluacionService.GetEvaluationById(id);
            return Request.CreateResponse(HttpStatusCode.OK, resultados);
        }

        [HttpPost]
        [Route("save-evaluation")]
        public HttpResponseMessage saveEvaluation(ReqEvaluation evaluation)
        {
            var resultados = _evaluacionService.SaveEvaluation(evaluation);
            return Request.CreateResponse(HttpStatusCode.OK, resultados);
        }
    }
}
