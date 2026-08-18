using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiSchool.Requests;

namespace WebApiSchool.WebApi
{
    [RoutePrefix("api/logros")]
    [Authorize]
    public class LogroController : ApiController
    {
        private readonly Services.LogroService _logroService;
        private readonly Services.ObsNotaService _obsNotaService;
        public LogroController(Services.LogroService logroService, Services.ObsNotaService obsNotaService)
        {
            _logroService = logroService;
            _obsNotaService = obsNotaService;
        }

        [HttpPost]
        [Route("logros-by-user-grado-asig-per")]
        public HttpResponseMessage FindLogrosByUserGradoAsignPer(Requests.ReqFindLogros findLogros)
        {
            var logros = _logroService.FindLogrosByUserGradoAsignPer(findLogros);
            return Request.CreateResponse(HttpStatusCode.OK, logros);
        }

        [HttpPost]
        [Route("save-logros")]
        public HttpResponseMessage saveLogros(ReqSaveLogros saveLogros)
        {
            var logros = _logroService.SaveLogros(saveLogros);
            return Request.CreateResponse(HttpStatusCode.OK, logros);
        }

        [HttpPut]
        [Route("update-logros")]
        public HttpResponseMessage updateLogros(ReqSaveLogros findLogros)
        {
            var logros = _logroService.UpdateLogros(findLogros);
            return Request.CreateResponse(HttpStatusCode.OK, logros);
        }

        [HttpDelete]
        [Route("delete-logros")]
        public HttpResponseMessage deleteLogros(string codLogro, ReqFindLogros find)
        {
            var result = _logroService.deleteLogros(codLogro, find);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        [HttpPost]
        [Route("get-codigo-planilla")]
        public HttpResponseMessage getCodigoPlanilla(ReqGetCodPlanilla find)
        {
            var codigoPlanilla = _logroService.GetCodPlanilla(find);
            return Request.CreateResponse(HttpStatusCode.OK, codigoPlanilla);
        }

        [HttpGet]
        [Route("get-logros-by-cod-planilla")]
        public HttpResponseMessage getLogrosByCodPlanilla(string codPlanilla, string usuario)
        {
            var logros = _logroService.getLogrosByPlanilla(codPlanilla, usuario);
            return Request.CreateResponse(HttpStatusCode.OK, logros);
        }

        [HttpGet]
        [Route("get-studient-by-cod-logro")]
        public HttpResponseMessage getStudientByCodLogro(string codLogro, string idPlanilla)
        {
            var students = _logroService.getNotasByCodLogro(codLogro, idPlanilla);
            return Request.CreateResponse(HttpStatusCode.OK, students);
        }

        [HttpPost]
        [Route("save-observador-nota")]
        public HttpResponseMessage saveObservadorNota(ReqObsNotas obsNotas)
        {
            var result = _obsNotaService.saveObservadorNota(obsNotas);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        [HttpGet]
        [Route("get-observador-nota")]
        public HttpResponseMessage getObservadorNota(int idPlanilla, int idMatricula, string codLogro)
        {
            var result = _obsNotaService.getObsNota(idPlanilla, idMatricula, codLogro);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        [HttpDelete]
        [Route("delete-observador-nota")]
        public HttpResponseMessage deleteObservadorNota(int idRegOb)
        {
            var result = _obsNotaService.deleteObsNota(idRegOb);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }
    }

}
