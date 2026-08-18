using System.Collections.Generic;
using System.Linq;
using WebApiSchool.Persitences;
using WebApiSchool.Responses;

namespace WebApiSchool.Services
{
    public class EvaluacionServiceImp : EvaluacionService
    {
        private readonly EvaluacionesRep _persitencia;

        public EvaluacionServiceImp(EvaluacionesRep persitencia)
        {
            _persitencia = persitencia;
        }
        public List<RespHelperEval> GetTiposEvaluaciones()
        {
            return _persitencia.GetTiposEvaluaciones()
                .Select(te => new RespHelperEval
                {
                    valor = te.valor,
                    descripcion = te.descripcion
                }).ToList();
        }
    }
}