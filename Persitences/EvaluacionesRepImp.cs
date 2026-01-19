using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiSchool.Entitys;

namespace WebApiSchool.Persitences
{
    public class EvaluacionesRepImp : EvaluacionesRep
    {
        private readonly ModelSchool _context;

        public EvaluacionesRepImp()
        {
            _context = new ModelSchool();
        }
        public List<HelperEvalEntity> GetTiposEvaluaciones()
        {
            string sqlGetTiposEvaluaciones = "SELECT valor, descripcion FROM vw_helper_evaluaciones";
            return _context.Database.SqlQuery<HelperEvalEntity>(sqlGetTiposEvaluaciones).ToList();
        }
    }
}