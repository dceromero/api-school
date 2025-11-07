using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
