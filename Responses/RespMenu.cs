using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WebApiSchool.Responses
{
    [DataContract]
    public class RespMenu
    {
        [DataMember]
        public string Opcion { get; set; }

        [DataMember]
        public string Descripcion { get; set; }

        [DataMember]
        public string Icon { get; set; }

        [DataMember]
        public List<RespSubMenu> subMenu { get; set; }
    }
}