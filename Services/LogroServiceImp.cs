using System;
using System.Collections.Generic;
using System.Linq;
using WebApiSchool.Entitys;
using WebApiSchool.Persitences;
using WebApiSchool.Requests;
using WebApiSchool.Responses;

namespace WebApiSchool.Services
{
    public class LogroServiceImp : LogroService
    {
        private readonly LogrosRep _logrosRep;

        public LogroServiceImp(LogrosRep logrosRep)
        {
            _logrosRep = logrosRep;
        }

        public List<RespLogro> deleteLogros(string codLogro, ReqFindLogros updateLogros)
        {
            if (_logrosRep.deleteLogros(codLogro) > 0)
            {
                return FindLogrosByUserGradoAsignPer(new ReqFindLogros
                {
                    codAsignatura = updateLogros.codAsignatura,
                    codGrado = updateLogros.codGrado,
                    periodo = updateLogros.periodo,
                    usuario = updateLogros.usuario
                });
            }
            throw new NotImplementedException("Contacte el Administrador");
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
                pc4 = lg.pc4,
                cantLogros = lg.cantLogros
            }).ToList();
        }

        public List<RespLogro> SaveLogros(ReqSaveLogros saveLogros)
        {
            if (_logrosRep.SaveLogros(saveLogros) > 0)
            {
                return FindLogrosByUserGradoAsignPer(new ReqFindLogros
                {
                    codAsignatura = saveLogros.codAsignatura,
                    codGrado = saveLogros.codGrado,
                    periodo = saveLogros.periodo,
                    usuario = saveLogros.usuario
                });
            }
            throw new NotImplementedException("Contacte al Administrador");
        }

        public List<RespLogro> UpdateLogros(ReqSaveLogros findLogros)
        {
            if (_logrosRep.UpdateLogros(new ReqUpdateLogros
            {
                codLogro = findLogros.codLogro,
                textoLg = findLogros.descLogro,
                cantNotas = findLogros.cantNotas,
                pc1 = findLogros.pc1,
                pc2 = findLogros.pc2,
                pc3 = findLogros.pc3,
                pc4 = findLogros.pc4
            }) > 0)
            {
                return FindLogrosByUserGradoAsignPer(new ReqFindLogros
                {
                    codAsignatura = findLogros.codAsignatura,
                    codGrado = findLogros.codGrado,
                    periodo = findLogros.periodo,
                    usuario = findLogros.usuario
                });
            }
            throw new NotImplementedException("Contacte al Administrador");
        }

        public string GetCodPlanilla(ReqGetCodPlanilla reqCodPlanilla)
        {
            return _logrosRep.GetCodPlanilla(reqCodPlanilla);
        }

        public List<LogroEntity> getLogrosByPlanilla(string codPlanilla, string usuario)
        {
            return _logrosRep.GetLogrosByPlanilla(codPlanilla, usuario);
        }

        public List<RespVWNotas> getNotasByCodLogro(string codLogro, string idPlanilla)
        {
            return _logrosRep.getNotasByCodLogro(codLogro, idPlanilla);
        }
    }
}