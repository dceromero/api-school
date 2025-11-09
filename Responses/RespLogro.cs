using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiSchool.Responses
{
    public class RespLogro
    {
        public string codLogro { get; set; }
        public string textoLg { get; set; }
        public int cantNotas { get; set; }
        public decimal pc1 { get; set; }
        public decimal pc2 { get; set; }
        public decimal pc3 { get; set; }
        public decimal pc4 { get; set; }
        public int cantLogros { get; set; }
    }
}