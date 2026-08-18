using System.Collections.Generic;
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
        public HttpResponseMessage SaveNota(List<ReqSaveNota> save)
        {
            _notasService.saveNota(save);
            return Request.CreateResponse(HttpStatusCode.Created);
        }

        [HttpGet]
        [Route("other-notes")]
        public HttpResponseMessage GetOtherNotes(string codPlanilla, string usuario)
        {
            var result = _notasService.getOtherNote(codPlanilla, usuario);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        [HttpPost]
        [Route("save-other-note")]
        public HttpResponseMessage SaveOtherNote(List<ReqSaveOtherNote> saveOtherNote)
        {
            _notasService.SaveOtherNote(saveOtherNote);
            return Request.CreateResponse(HttpStatusCode.Created);
        }
    }
}
