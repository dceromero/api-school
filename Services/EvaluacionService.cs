using System.Collections.Generic;
using WebApiSchool.Entitys;
using WebApiSchool.Requests;
using WebApiSchool.Responses;

namespace WebApiSchool.Services
{
    public interface EvaluacionService
    {
        List<RespHelperEval> GetTiposEvaluaciones();
        List<RespEvaluaciones> GetEvaluationById(int id);
        List<RespEvaluaciones> SaveEvaluation(ReqEvaluation evaluation);
    }
}
