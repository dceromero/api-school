
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WebApiSchool.Requests
{
    public class ReqSaveComment
    {
        public int periodo { get; set; }
        public int idmatricula { get; set; }
        public string comentario { get; set; }
        public string grado { get; set; }
        public string grupo { get; set; }

    }
}