using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiSchool.Requests;

namespace WebApiSchool.WebApi
{
    [RoutePrefix("api/notas")]
    [Authorize]
    public class NotasController : ApiController
    {
        private readonly Services.NotasService _notasService;
        public NotasController(Services.NotasService notasService)
        {
            _notasService = notasService;
        }
        [HttpPost]
        [Route("save")]
        public HttpResponseMessage SaveNota(ReqSaveNota save)
        {
            _notasService.saveNota(save);
            return Request.CreateResponse(HttpStatusCode.Created);
        }
    }
}
