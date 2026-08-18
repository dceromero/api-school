using System.Collections.Generic;
using WebApiSchool.Entitys;
using WebApiSchool.Responses;

namespace WebApiSchool.Services
{
    public interface VencimientosService
    {
        List<RespVencimiento> GetVencimientos(string user);

        List<RespGrado> GetGrados(string user);

        List<RespAsignatura> GetAsignaturas(string user, string grado);
    }
}
