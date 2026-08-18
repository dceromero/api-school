using System.Collections.Generic;
using WebApiSchool.Responses;

namespace WebApiSchool.Services
{
    public interface EvaluacionService
    {
        List<RespHelperEval> GetTiposEvaluaciones();
    }
}
