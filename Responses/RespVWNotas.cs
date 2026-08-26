namespace WebApiSchool.Responses
{
    public class RespVWNotas
    {
        public int idmatricula { get; set; }
        public int idPlanilla { get; set; }
        public string CodLogro { get; set; }
        public string apellidos { get; set; }
        public string nombres { get; set; }
        public decimal n1 { get; set; }
        public decimal n2 { get; set; }
        public decimal n3 { get; set; }
        public decimal n4 { get; set; }
        public int numSemana { get; set; }
        public bool seguimiento { get; set; }

        public bool piar { get; set; }
    }
}