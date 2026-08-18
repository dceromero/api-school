using System.Collections.Generic;
using System.Linq;
using WebApiSchool.Entitys;

namespace WebApiSchool.Persitences
{
    public class MenuRepImp : MenuRep
    {
        private readonly ModelSchool _context;

        public MenuRepImp()
        {
            _context = new ModelSchool();
        }

        public List<MenuEntity> GetMenuByUserGroup(string grupoUsr)
        {
            string sqlGetMenuByUserGroup = "SELECT Opcion,Descripcion,Nodopadre, tipoOp,Secuencia, urlOption, iconOption " +
                $"FROM vm_menu where visible<>0  AND  permiso <> 0 and GRupoUsr= '{grupoUsr}' " +
                "order by Nodopadre,secuencia,TipoOp";

            return _context.Database.SqlQuery<MenuEntity>(sqlGetMenuByUserGroup).ToList();
        }
    }
}