using System.Collections.Generic;
using System.Linq;
using WebApiSchool.Entitys;
using WebApiSchool.Persitences;
using WebApiSchool.Responses;

namespace WebApiSchool.Services
{
    public class VencimientosServiceImp : VencimientosService
    {
        private readonly VencimientosRep repository;

        public VencimientosServiceImp(VencimientosRep repository)
        {
            this.repository = repository;
        }

        public List<RespAsignatura> GetAsignaturas(string user, string grado)
        {
            return repository.GetAsignaturas(user, grado);
        }

        public List<RespGrado> GetGrados(string user)
        {
            return repository.GetGrados(user);
        }

        public List<RespVencimiento> GetVencimientos(string user)
        {
            return repository.GetVencimientos(user).Select(data => new RespVencimiento
            {
                grado = $"{data.codGrado}-{data.descGrado}",
                asignatura = data.asignatura,
                fechaVencimiento = data.fechaVigencia,
                periodo = data.periodo,
                cantLogros = data.cantLogros,
                cantNotasIng = data.cantNotasIng
            }).ToList();
        }
    }
}