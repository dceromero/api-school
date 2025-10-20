using WebApiSchool.Requests;
using WebApiSchool.Responses;

namespace WebApiSchool.Services
{
    public interface UsuarioService
    {
        RespUsuario GetUsuario(ReqUser reqUser);
    }
}
