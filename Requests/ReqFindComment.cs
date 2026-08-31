
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WebApiSchool.Requests
{
    public class ReqFindComment
    {
        public int periodo { get; set; }
        public string grado { get; set; }
        public string grupo { get; set; }

    }
}