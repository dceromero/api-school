using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiSchool.Entitys;

namespace WebApiSchool.Persitences
{
    public interface ContenidoRep
    {
        List<ContenidoEntity> GetContentById(int id);

        bool SaveContent(ContenidoEntity contenido);
    }
}
