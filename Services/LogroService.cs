using System.Collections.Generic;
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
    }
}
