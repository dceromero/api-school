using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
            string sqlGetMenuByUserGroup = "SELECT Opcion,Descripcion,Nodopadre,trim(tipoOp) tipoOp,Secuencia " +
                $"FROM Q0Opciones where visible<>0  AND  permiso <> 0 and GRupoUsr= '{grupoUsr}' " +
                "order by Nodopadre,secuenciaOP,TipoOp";

            return _context.Database.SqlQuery<MenuEntity>(sqlGetMenuByUserGroup).ToList();
        }
    }
}