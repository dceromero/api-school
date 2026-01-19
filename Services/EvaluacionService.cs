using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiSchool.Responses;

namespace WebApiSchool.Services
{
    public interface EvaluacionService
    {
        List<RespHelperEval> GetTiposEvaluaciones();
    }
}
