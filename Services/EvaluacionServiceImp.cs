using System.Collections.Generic;
using System.Linq;
using WebApiSchool.Entitys;
using WebApiSchool.Persitences;
using WebApiSchool.Requests;
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

        public List<RespEvaluaciones> GetEvaluationById(int id)
        {
            return _persitencia.GetEvaluationById(id);
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

        public List<RespEvaluaciones> SaveEvaluation(ReqEvaluation evaluation)
        {
            _persitencia.saveEvaluation(evaluation);
            return _persitencia.GetEvaluationById(evaluation.id);
        }
    }
}