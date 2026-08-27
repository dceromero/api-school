using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiSchool.Entitys;

namespace WebApiSchool.Services
{
    public interface ContenidoService
    {
        List<ContenidoEntity> GetContentById(int id);

        List<ContenidoEntity> SaveContent(ContenidoEntity contenido);
    }
}
