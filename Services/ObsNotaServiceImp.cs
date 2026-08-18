using System.Collections.Generic;
using WebApiSchool.Persitences;
using WebApiSchool.Responses;

namespace WebApiSchool.Services
{
    public class ObsNotaServiceImp : ObsNotaService
    {
        private readonly ObservadorNotaRep _repository;

        public ObsNotaServiceImp(ObservadorNotaRep repository)
        {
            _repository = repository;
        }

        public List<RespObsNota> getObsNota(int idPlanilla, int idMatricula, string codLogro)
        {
            return _repository.getObsNota(idPlanilla, idMatricula, codLogro);
        }

        public RespHelperEval saveObservadorNota(ReqObsNotas obsNotas)
        {
            return _repository.saveObservadorNota(obsNotas);
        }

        public RespHelperEval deleteObsNota(int idRegOb)
        {
            return _repository.deleteObsNota(idRegOb);
        }
    }
}