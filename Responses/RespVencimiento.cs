using System.Runtime.Serialization;

namespace WebApiSchool.Responses
{
    [DataContract]
    public class RespVencimiento
    {

        [DataMember]
        public string grado { get; set; }

        [DataMember]
        public string grupo { get; set; }

        [DataMember]
        public string asignatura { get; set; }

        [DataMember]
        public string fechaVencimiento { get; set; }

        [DataMember]
        public int periodo { get; set; }

        [DataMember]
        public int cantLogros { get; set; }

        [DataMember]
        public int cantNotasIng { get; set; }
    }
}