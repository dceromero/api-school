using System;
using System.Collections.Generic;
using System.Linq;
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
        public LogroController(Services.LogroService logroService)
        {
            _logroService = logroService;
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
    }
}
