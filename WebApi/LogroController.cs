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
    }
}
