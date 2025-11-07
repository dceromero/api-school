using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiSchool.Entitys
{
    public class LogroEntity
    {
        public string codLogro { get; set; }
        public string textoLg { get; set; }
        public int cantNotas { get; set; }
        public string codAsignatura { get; set; }
        public string codGrado { get; set; }
        public int periodo { get; set; }
        public string usuario { get; set; }
        public decimal pc1 { get; set; }
        public decimal pc2 { get; set; }
        public decimal pc3 { get; set; }
        public decimal pc4 { get; set; }

    }
}