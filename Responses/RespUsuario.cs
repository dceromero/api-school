using System.Runtime.Serialization;

namespace WebApiSchool.Responses
{
    [DataContract]
    public class RespUsuario
    {
        [DataMember]
        public string fullname { get; set; }

        [DataMember]
        public string userName { get; set; }

        [DataMember]
        public string userGroup { get; set; }
    }
}