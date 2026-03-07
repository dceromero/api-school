using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiSchool.Persitences;
using WebApiSchool.Responses;

namespace WebApiSchool.Services
{
    public interface ObsNotaService
    {
        RespHelperEval saveObservadorNota(ReqObsNotas obsNotas);
        List<RespObsNota> getObsNota(int idPlanilla, int idMatricula, string codLogro);
        RespHelperEval deleteObsNota(int idRegOb);
    }
}
