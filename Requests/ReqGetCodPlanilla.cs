using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiSchool.Requests
{
    public class ReqGetCodPlanilla
    {
        public string codGrado { get; set; }
        public string grupo { get; set; }
        public string periodo { get; set; }
        public string codAsignatura { get; set; }
    }
}