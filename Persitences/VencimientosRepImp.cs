using System.Collections.Generic;
using System.Linq;
using WebApiSchool.Entitys;

namespace WebApiSchool.Persitences
{
    public class VencimientosRepImp : VencimientosRep
    {
        private readonly ModelSchool _context;

        public VencimientosRepImp()
        {
            _context = new ModelSchool();
        }
        public List<VecimientosEntity> GetVencimientos(string user)
        {
            string sqlGetVencimientos = $"select  * from vw_vencimientos where nombreUsr = '{user}'";
            return _context.Database.SqlQuery<VecimientosEntity>(sqlGetVencimientos).ToList();
        }

        public List<RespGrado> GetGrados(string user)
        {
            string sqlGetGrados = $"select distinct codGrado, DescGrado from vw_vencimientos where nombreUsr = '{user}'";
            return _context.Database.SqlQuery<RespGrado>(sqlGetGrados).ToList();
        }

        public List<RespAsignatura> GetAsignaturas(string user, string grado)
        {
            string sqlGetAsign = $"select distinct codAsignatura, asignatura from vw_vencimientos where nombreUsr = '{user}' and codGrado ='{grado}'";
            return _context.Database.SqlQuery<RespAsignatura>(sqlGetAsign).ToList();
        }
    }
}