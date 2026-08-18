using System.Collections.Generic;
using WebApiSchool.Entitys;

namespace WebApiSchool.Persitences
{
    public interface VencimientosRep
    {
        List<VecimientosEntity> GetVencimientos(string user);

        List<RespGrado> GetGrados(string user);

        List<RespAsignatura> GetAsignaturas(string user, string grado);
    }
}
