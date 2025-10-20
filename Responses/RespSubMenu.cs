using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebApiSchool.Responses
{
    [DataContract]
    public class RespSubMenu
    {
        [DataMember]
        public string Opcion { get; set; }


        [DataMember]
        public string Descripcion { get; set; }
    }
}