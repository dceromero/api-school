using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiSchool.Entitys;
using WebApiSchool.Requests;
using WebApiSchool.Responses;

namespace WebApiSchool.Persitences
{
    public interface LogrosRep
    {
        List<LogroEntity> GetLogrosByUserGradoAsignPer(ReqFindLogros findLogros);
        List<RespLogro> SaveLogros(ReqSaveLogros findLogros);
        List<RespLogro> UpdateLogros(ReqSaveLogros findLogros);
    }
}
