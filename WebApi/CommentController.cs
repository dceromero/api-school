
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Services.Description;
using WebApiSchool.Entitys;
using WebApiSchool.Requests;
using WebApiSchool.Services;

namespace WebApiSchool.WebApi
{
    [RoutePrefix("api/comment")]
    [Authorize]
    public class CommentController:ApiController
    {
        private readonly CommentService _service;
        public CommentController(CommentService service)
        {
            this._service = service;
        }

        [HttpGet]
        [Route("get-study-to-comment")]
        public HttpResponseMessage getStudyToComment([FromUri]ReqFindComment findComment)
        {
            var resultados = _service.GetRepList(findComment);
            return Request.CreateResponse(HttpStatusCode.OK, resultados);
        }

        [HttpPost]
        [Route("save-comment")]
        public HttpResponseMessage SaveContent(ReqSaveComment comment)
        {
            var resultados = _service.SaveComment(comment);
            return Request.CreateResponse(HttpStatusCode.OK, resultados);
        }

    }
}