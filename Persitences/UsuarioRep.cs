using WebApiSchool.Requests;

namespace WebApiSchool.Persitences
{
    public interface UsuarioRep
    {
        UsuarioEntity GetUsuario(ReqUser reqUser);
    }
}
