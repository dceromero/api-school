using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiSchool.Services;

namespace WebApiSchool.WebApi
{
    [Authorize]
    [RoutePrefix("api/vencimientos")]
    public class VencimientosController : ApiController
    {
        private readonly VencimientosService service;

        public VencimientosController(VencimientosService _service)
        {
            this.service = _service;
        }

        [HttpGet]
        [Route("vencimientos-by-user")]
        public HttpResponseMessage GetVencimientosByUser(string user)
        {
            var vencimientos = this.service.GetVencimientos(user);
            return Request.CreateResponse(HttpStatusCode.OK, vencimientos);
        }

        [HttpGet]
        [Route("grados-by-user")]
        public HttpResponseMessage GetGrados(string user)
        {
            var vencimientos = this.service.GetGrados(user);
            return Request.CreateResponse(HttpStatusCode.OK, vencimientos);
        }

        [HttpGet]
        [Route("asignatura-by-user-and-grado")]
        public HttpResponseMessage GetAsignatura(string user, string grado)
        {
            var vencimientos = this.service.GetAsignaturas(user, grado);
            return Request.CreateResponse(HttpStatusCode.OK, vencimientos);
        }
    }
}
