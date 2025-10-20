using WebApiSchool.Persitences;
using WebApiSchool.Responses;

namespace WebApiSchool.Mapper
{
    public static class UsuarioMapper
    {
        public static RespUsuario entityToResponse(UsuarioEntity entity)
        {
            if (entity == null)
            {
                return null;
            }
            RespUsuario response = new Responses.RespUsuario();
            response.fullname = entity.nombreComp;
            response.userName = entity.nombreUsr;
            response.userGroup = entity.grupoUsr;
            return response;
        }
    }
}