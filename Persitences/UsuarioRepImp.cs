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
            string sqlGetUsuario = "Select NombreComp ,NombreUsr, psw , GrupoUsr, yearDefault, defaultPeriodo  from vw_userLogin " +
                                    $"where estado = 'A' and psw = '{reqUser.password}' " +
                                    $"and NombreUsr ='{reqUser.nombreUsu}' ";
            return _context.Database.SqlQuery<UsuarioEntity>(sqlGetUsuario).FirstOrDefault();
        }
    }

}