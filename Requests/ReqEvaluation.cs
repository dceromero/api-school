
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WebApiSchool.Requests
{
    public class ReqEvaluation
    {
        public int id { get; set; }
        public string item { get; set; }
        public string evaluacion { get; set; }
        public string detalle { get; set; }
        public DateTime fecha { get; set; }
    }
}