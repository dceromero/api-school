
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WebApiSchool.Responses
{
    public class RespComment
    {
        public int periodo { get; set; }
        public string grado { get; set; }
        public string grupo { get; set; }
        public int idmatricula { get; set; }
        public string apellidos { get; set; }
        public string nombres { get; set; }
        public string comentario { get; set; }
        public DateTime? fecregitro { get; set; }
    }
}