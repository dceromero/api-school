using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApiSchool.Entitys;
using WebApiSchool.Requests;

namespace WebApiSchool.Persitences
{
    public class EvaluacionesRepImp : EvaluacionesRep
    {
        private readonly ModelSchool _context;

        public EvaluacionesRepImp()
        {
            _context = new ModelSchool();
        }

        public List<RespEvaluaciones> GetEvaluationById(int id)
        {
            string sqlGetEvaluaciones = $"SELECT * FROM vw_evaluaciones where id ='{id}'";
            return _context.Database.SqlQuery<RespEvaluaciones>(sqlGetEvaluaciones).ToList();
        }

        public List<HelperEvalEntity> GetTiposEvaluaciones()
        {
            string sqlGetTiposEvaluaciones = "SELECT valor, descripcion FROM vw_helper_evaluaciones";
            return _context.Database.SqlQuery<HelperEvalEntity>(sqlGetTiposEvaluaciones).ToList();
        }

        public bool saveEvaluation(ReqEvaluation evaluation)
        {
            StringBuilder sqlUpdate = new StringBuilder($"update B3EvaluacionesNt set evaluacion ='{evaluation.evaluacion}', ");
            sqlUpdate.Append($"detalle ='{evaluation.detalle}', fecha ='{evaluation.fecha.ToString("yyyy-MM-dd")}' ");
            sqlUpdate.AppendLine($"Where id='{evaluation.id}' and item ='{evaluation.item}' ");
                return _context.Database.ExecuteSqlCommand(sqlUpdate.ToString()) > 0;
        }
    }
}