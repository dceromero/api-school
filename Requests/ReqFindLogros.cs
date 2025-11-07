using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiSchool.Requests
{
    public class ReqFindLogros
    {
        public string codAsignatura { get; set; }
        public string codGrado { get; set; }
        public int periodo { get; set; }
        public string usuario { get; set; }
    }
}