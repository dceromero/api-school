using System.Linq;
using WebApiSchool.Requests;

namespace WebApiSchool.Persitences
{
    public class UsuarioRepImp : UsuarioRep
    {
        private readonly ModelSchool _context;


        public UsuarioRepImp()
        {
            _context = new ModelSchool();
        }
        public UsuarioEntity GetUsuario(ReqUser reqUser)
        {
            string sqlGetUsuario = "Select NombreComp ,NombreUsr,dbo.fnc_ctr('turbopascal',contrasenaUsr) password, GrupoUsr from w2usuarios " +
            $"where Estado in ('A') and dbo.fnc_ctr('turbopascal',contrasenaUsr) = '{reqUser.constraseña}' " +
            $"and NombreUsr ='{reqUser.nombreUsu}' ";
            return _context.Database.SqlQuery<UsuarioEntity>(sqlGetUsuario).FirstOrDefault();
        }
    }

}