using System.Collections.Generic;
using WebApiSchool.Entitys;
using WebApiSchool.Requests;
using WebApiSchool.Responses;

namespace WebApiSchool.Services
{
    public interface LogroService
    {
        List<RespLogro> FindLogrosByUserGradoAsignPer(ReqFindLogros findLogros);
        List<RespLogro> SaveLogros(ReqSaveLogros saveLogros);
        List<RespLogro> UpdateLogros(ReqSaveLogros updateLogros);
        List<RespLogro> deleteLogros(string codLogro, ReqFindLogros updateLogros);
        string GetCodPlanilla(ReqGetCodPlanilla reqCodPlanilla);
        List<LogroEntity> getLogrosByPlanilla(string codPlanilla, string usuario);
        List<RespVWNotas> getNotasByCodLogro(string codLogro, string idPlanilla);
    }
}
