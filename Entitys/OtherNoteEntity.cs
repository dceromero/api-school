namespace WebApiSchool.Entitys
{
    public class OtherNoteEntity
    {
        public int idPlanilla { get; set; }
        public int idMatricula { get; set; }
        public string apellidos { get; set; }
        public string nombres { get; set; }
        public int ausencias { get; set; }
        public decimal nIcfes { get; set; }
        public decimal notaRp { get; set; }
        public decimal notaRF { get; set; }
        public decimal notaNiv { get; set; }
        public decimal notaEU { get; set; }
    }
}