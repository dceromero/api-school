
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using WebApiSchool.Entitys;
using WebApiSchool.Services;

namespace WebApiSchool.WebApi
{
    [RoutePrefix("api/content")]
    [Authorize]
    public class ContenidoController:ApiController
    {
        private readonly Services.ContenidoService _service;

        public ContenidoController(Services.ContenidoService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("get-content-by-id")]
        public HttpResponseMessage getContentById(int id)
        {
            var resultados = _service.GetContentById(id);
            return Request.CreateResponse(HttpStatusCode.OK, resultados);
        }

        [HttpPost]
        [Route("save-content")]
        public HttpResponseMessage SaveContent(ContenidoEntity content)
        {
            var resultados = _service.SaveContent(content) ;
            return Request.CreateResponse(HttpStatusCode.OK, resultados);
        }
    }
}