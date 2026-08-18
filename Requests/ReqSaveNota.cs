namespace WebApiSchool.Requests
{
    public class ReqSaveNota
    {
        public int idmatricula { get; set; }
        public int idPlanilla { get; set; }
        public string CodLogro { get; set; }
        public decimal n1 { get; set; }
        public decimal n2 { get; set; }
        public decimal n3 { get; set; }
        public decimal n4 { get; set; }
    }
}