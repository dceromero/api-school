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

        public List<RespLogro> SaveLogros(ReqSaveLogros saveLogros)
        {
            StringBuilder sqlSaveLogros = new StringBuilder($"insert into B3Indicadores values (dbo.fnc_get_Parameter('Default_ano'), ");
            sqlSaveLogros.AppendLine($"dbo.fnc_get_max_id_codLogro(), ");
            sqlSaveLogros.AppendLine($"'{saveLogros.descLogro.ToUpper()}', {saveLogros.periodo}, {saveLogros.cantNotas}, {saveLogros.pc1 }, ");
            sqlSaveLogros.AppendLine($"{saveLogros.pc2 }, {saveLogros.pc3 }, {saveLogros.pc4 }, 1, 1, 1, 0, '{saveLogros.usuario}', 'Web', getDate(), ");
            sqlSaveLogros.AppendLine($"'{saveLogros.codGrado}', '{saveLogros.codAsignatura}', dbo.fnc_get_max_consecut(), dbo.fnc_get_max_id_indicadores() ) ");
            string tsql = sqlSaveLogros.ToString();
            throw new System.NotImplementedException();
        }

        public List<RespLogro> UpdateLogros(ReqSaveLogros findLogros)
        {
            throw new System.NotImplementedException();
        }
    }
}