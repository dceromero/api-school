using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApiSchool.Entitys;
using WebApiSchool.Requests;
using WebApiSchool.Responses;

namespace WebApiSchool.Persitences
{
    public class LogrosRepImp : LogrosRep
    {
        private readonly ModelSchool _context;

        public LogrosRepImp(ModelSchool context)
        {
            _context = context;
        }

        public List<LogroEntity> GetLogrosByUserGradoAsignPer(ReqFindLogros findLogros)
        {
            StringBuilder sqlGetLogrosByUserGradoAsignPer = new StringBuilder("SELECT * FROM vw_logros ");
            sqlGetLogrosByUserGradoAsignPer.AppendLine($"WHERE codAsignatura = '{findLogros.codAsignatura}' ");
            sqlGetLogrosByUserGradoAsignPer.AppendLine($"AND codGrado = '{findLogros.codGrado}' ");
            sqlGetLogrosByUserGradoAsignPer.AppendLine($"AND periodo = '{findLogros.periodo}' ");
            sqlGetLogrosByUserGradoAsignPer.AppendLine($"AND usuario = '{findLogros.usuario}'");

            return _context.Database.SqlQuery<LogroEntity>(sqlGetLogrosByUserGradoAsignPer.ToString()).ToList();
        }

        public int SaveLogros(ReqSaveLogros saveLogros)
        {
            StringBuilder sqlSaveLogros = new StringBuilder($"insert into B3Indicadores values (dbo.fnc_get_Parameter('Default_ano'), ");
            sqlSaveLogros.AppendLine($" '0', '{saveLogros.descLogro.ToUpper()}', {saveLogros.periodo}, {saveLogros.cantNotas}, {saveLogros.pc1}, ");
            sqlSaveLogros.AppendLine($"{saveLogros.pc2}, {saveLogros.pc3}, {saveLogros.pc4}, 1, 1, 1, 0, '{saveLogros.usuario}', 'Web', getDate(), ");
            sqlSaveLogros.AppendLine($"'{saveLogros.codGrado}', '{saveLogros.codAsignatura}', dbo.fnc_get_max_consecut() ) ");
            string tsql = sqlSaveLogros.ToString();
            return _context.Database.ExecuteSqlCommand(tsql);
        }

        public int UpdateLogros(ReqUpdateLogros updateLogros)
        {
            StringBuilder sqlSaveLogros = new StringBuilder($"update B3Indicadores set cantNotas='{updateLogros.cantNotas}', ");
            sqlSaveLogros.AppendLine($"textoLg='{updateLogros.textoLg.ToUpper()}', pc1={updateLogros.pc1}, pc2={updateLogros.pc2}, ");
            sqlSaveLogros.AppendLine($"pc3={updateLogros.pc3}, pc4={updateLogros.pc4} ");
            sqlSaveLogros.Append($"Where codLogro ='{updateLogros.codLogro}'");
            string tsql = sqlSaveLogros.ToString();
            return _context.Database.ExecuteSqlCommand(tsql);
        }

        public int deleteLogros(string codLogro)
        {
            string tsql = $"delete from B3Indicadores Where codLogro ='{codLogro}'";
            return _context.Database.ExecuteSqlCommand(tsql);
        }

        public string GetCodPlanilla(ReqGetCodPlanilla reqCodPlanilla)
        {
            StringBuilder sqlGetCodPlanilla = new StringBuilder($"SELECT dbo.Fnc_getCodplanilla('{reqCodPlanilla.codGrado}','{reqCodPlanilla.grupo}',  ");
            sqlGetCodPlanilla.AppendLine($" '{reqCodPlanilla.periodo}', '{reqCodPlanilla.codAsignatura}') ");
            var result = _context.Database.SqlQuery<string>(sqlGetCodPlanilla.ToString()).FirstOrDefault();
            return result;
        }

        public List<LogroEntity> GetLogrosByPlanilla(string codPlanilla, string usuario)
        {
            StringBuilder sqlGetLogrosByUserGradoAsignPer = new StringBuilder($"exec Pr_getListaLogros '{codPlanilla}','{usuario}','webApi' ");
            return _context.Database.SqlQuery<LogroEntity>(sqlGetLogrosByUserGradoAsignPer.ToString()).ToList();
        }

        public List<RespVWNotas> getNotasByCodLogro(string codLogro, string idPlanilla)
        {
            string tsql = $"SELECT *, DATEPART(ISO_WEEK, GETDATE()) as numSemana FROM vw_calificar_logros WHERE CodLogro = '{codLogro}' and idPlanilla ='{idPlanilla}'";
            return _context.Database.SqlQuery<RespVWNotas>(tsql).ToList();
        }
    }
}