namespace WebApiSchool
{
    public class ReqObsNotas
    {
        public int idplanilla { get; set; }
        public int idMatricula { get; set; }
        public string codLogro { get; set; }
        public string usuario { get; set; }
        public string tipoObs { get; set; }
        public string obs { get; set; }
        public string comentario { get; set; }        
        public bool cumplido { get; set; }
        public string estado { get; set; }
        public int numSemana { get; set; }

    }
}