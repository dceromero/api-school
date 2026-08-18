using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApiSchool.Responses;

namespace WebApiSchool.Persitences
{
    public class ObservadorNotaRepImp : ObservadorNotaRep
    {
        private readonly ModelSchool _context;

        public ObservadorNotaRepImp(ModelSchool context)
        {
            _context = context;
        }

        public List<RespObsNota> getObsNota(int idPlanilla, int idMatricula, string codLogro)
        {
            string tsql = $"SELECT idRegOb, tipoObs, observacion, cumplido, comentarioAd, estado FROM B1AdmObservadorNt " +
                $"WHERE idPlanilla = {idPlanilla} AND idMatricula = {idMatricula} AND codLogro = '{codLogro}'";
            var result = _context.Database.SqlQuery<RespObsNota>(tsql).ToList();
            return result;
        }

        public RespHelperEval saveObservadorNota(ReqObsNotas obsNotas)
        {
            int cumplido = obsNotas.cumplido ? 1 : 0;
            StringBuilder tsql = new StringBuilder("INSERT INTO B1AdmObservadorNt  ");
            tsql.Append($"values({obsNotas.idplanilla}, {obsNotas.idMatricula}, ");
            tsql.Append($"'{obsNotas.tipoObs}', 1,'{obsNotas.obs}', '{DateTime.Now.ToString("yyyy-MM-dd HH:mm")}',");
            tsql.Append($"{cumplido} , '{obsNotas.comentario}', '{obsNotas.estado}', '{DateTime.Now.ToString("yyyy-MM-dd HH:mm")}',");
            tsql.Append($"'WebApi', '{obsNotas.usuario}', {obsNotas.numSemana}, '{DateTime.Now.ToString("yyyy-MM-dd HH:mm")}', '{obsNotas.codLogro}',");
            tsql.Append(" 0, 'no_aplica')");
            if (_context.Database.ExecuteSqlCommand(tsql.ToString()) > 0)
            {
                return new RespHelperEval
                {
                    valor = "1",
                    descripcion = "Observación guardada correctamente"
                };
            }
            return new RespHelperEval
            {
                valor = "0",
                descripcion = "Error al guardar la observación"
            };
        }

        public RespHelperEval deleteObsNota(int idRegOb)
        {
            string tsql = $"DELETE FROM B1AdmObservadorNt WHERE idRegOb = {idRegOb}";
            if (_context.Database.ExecuteSqlCommand(tsql) > 0)
            {
                return new RespHelperEval
                {
                    valor = "1",
                    descripcion = "Observación eliminada correctamente"
                };
            }
            return new RespHelperEval
            {
                valor = "0",
                descripcion = "Error al eliminar la observación"
            };
        }
    }
}