using System.Runtime.Serialization;

namespace WebApiSchool.Responses
{
    [DataContract]
    public class RespSubMenu
    {
        [DataMember]
        public string Opcion { get; set; }


        [DataMember]
        public string Descripcion { get; set; }

        [DataMember]
        public string Url { get; set; }

        [DataMember]
        public string Icon { get; set; }
    }
}