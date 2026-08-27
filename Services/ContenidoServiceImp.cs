
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using WebApiSchool.Entitys;
using WebApiSchool.Persitences;

namespace WebApiSchool.Services
{
    public class ContenidoServiceImp : ContenidoService
    {
        private readonly ContenidoRep _persitencia;

        public ContenidoServiceImp(ContenidoRep persitencia)
        {
            _persitencia = persitencia;
        }
        public List<ContenidoEntity> GetContentById(int id)
        {
            return _persitencia.GetContentById(id);
        }

        public List<ContenidoEntity> SaveContent(ContenidoEntity contenido)
        {
            _persitencia.SaveContent(contenido);
            return _persitencia.GetContentById(contenido.id);
        }
    }
}