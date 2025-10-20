using WebApiSchool.Mapper;
using WebApiSchool.Persitences;
using WebApiSchool.Requests;
using WebApiSchool.Responses;

namespace WebApiSchool.Services
{
    public class UsuarioServiceImp : UsuarioService
    {
        private readonly UsuarioRep repository;
        public UsuarioServiceImp(UsuarioRep repository)
        {
            this.repository = repository;
        }
        public RespUsuario GetUsuario(ReqUser reqUser)
        {
           return UsuarioMapper.entityToResponse(repository.GetUsuario(reqUser));
        }
    }
}