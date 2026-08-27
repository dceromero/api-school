
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WebApiSchool.Entitys
{
    public class ContenidoEntity
    {
        public int id { get; set; }
        public string item { get; set; }
        public string comentario { get; set; }
        public string contenido { get; set; }
        public DateTime? fecRegistro { get; set; } 
        public string usuario { get; set; }

    }
}