using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiSchool.Responses;

namespace WebApiSchool.Persitences
{
    public interface ObservadorNotaRep
    {
        RespHelperEval saveObservadorNota(ReqObsNotas obsNotas);

        List<RespObsNota> getObsNota(int idPlanilla, int idMatricula, string codLogro);

        RespHelperEval deleteObsNota(int idRegOb);
    }
}