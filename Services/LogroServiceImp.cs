using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiSchool.Persitences;
using WebApiSchool.Requests;
using WebApiSchool.Responses;

namespace WebApiSchool.Services
{
    public class LogroServiceImp: LogroService
    {
        private readonly LogrosRep _logrosRep;

        public LogroServiceImp(LogrosRep logrosRep)
        {
            _logrosRep = logrosRep;
        }

        public List<RespLogro> FindLogrosByUserGradoAsignPer(ReqFindLogros findLogros)
        {
            return _logrosRep.GetLogrosByUserGradoAsignPer(findLogros).Select(lg => new RespLogro
            {
                codLogro = lg.codLogro,
                textoLg = lg.textoLg,
                cantNotas = lg.cantNotas,
                pc1 = lg.pc1,
                pc2 = lg.pc2,
                pc3 = lg.pc3,
                pc4 = lg.pc4
            }).ToList();
        }

        public List<RespLogro> SaveLogros(ReqSaveLogros saveLogros)
        {
            _logrosRep.SaveLogros(saveLogros);
            throw new NotImplementedException();
        }

        public List<RespLogro> UpdateLogros(ReqSaveLogros findLogros)
        {
            throw new NotImplementedException();
        }
    }
}