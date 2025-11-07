using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
