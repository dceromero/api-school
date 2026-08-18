namespace WebApiSchool.Requests
{
    public class ReqSaveLogros
    {
        public string codAsignatura { get; set; }
        public string codGrado { get; set; }
        public int periodo { get; set; }
        public string usuario { get; set; }
        public string codLogro { get; set; }
        public string descLogro { get; set; }
        public int cantNotas { get; set; }
        public decimal pc1 { get; set; }
        public decimal pc2 { get; set; }
        public decimal pc3 { get; set; }
        public decimal pc4 { get; set; }
    }
}