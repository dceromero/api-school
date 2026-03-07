using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiSchool.Requests
{
    public class ReqSaveOtherNote
    {
        public int idPlanilla { get; set; }
        public int idMatricula { get; set; }
        public int ausencias { get; set; }
        public decimal nIcfes { get; set; }
        public decimal notaRp { get; set; }
        public decimal notaRF { get; set; }
        public decimal notaNiv { get; set; }
        public decimal notaEU { get; set; }
    }
}