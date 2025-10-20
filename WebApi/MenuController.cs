using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiSchool.Services;

namespace WebApiSchool.WebApi
{
    [Authorize]
    [RoutePrefix("api/menu")]
    public class MenuController : ApiController
    {
       private readonly MenuService service;

        public MenuController(MenuService _service)
        {
            this.service = _service;
        }
        [HttpGet]
        [Route("menu-by-group")]
        public HttpResponseMessage GetMenuByUserGroup(string grupoUsr)
        {
            var menu = this.service.GetMenuByUserGroup(grupoUsr);
            return Request.CreateResponse(HttpStatusCode.OK, menu);
        }
    }
}