using System.Collections.Generic;
using WebApiSchool.Entitys;
using WebApiSchool.Requests;

namespace WebApiSchool.Persitences
{
    public interface EvaluacionesRep
    {
        List<HelperEvalEntity> GetTiposEvaluaciones();

        List<RespEvaluaciones> GetEvaluationById(int id);

        bool saveEvaluation(ReqEvaluation evaluation);
    }
}
