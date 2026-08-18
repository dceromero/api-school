using System.Collections.Generic;
using WebApiSchool.Entitys;
using WebApiSchool.Requests;
using WebApiSchool.Responses;

namespace WebApiSchool.Persitences
{
    public interface LogrosRep
    {
        List<LogroEntity> GetLogrosByUserGradoAsignPer(ReqFindLogros findLogros);
        int SaveLogros(ReqSaveLogros findLogros);
        int UpdateLogros(ReqUpdateLogros findLogros);
        int deleteLogros(string codLogro);
        string GetCodPlanilla(ReqGetCodPlanilla reqCodPlanilla);
        List<LogroEntity> GetLogrosByPlanilla(string codPlanilla, string usuario);
        List<RespVWNotas> getNotasByCodLogro(string codLogro, string idPlanilla);
    }
}
