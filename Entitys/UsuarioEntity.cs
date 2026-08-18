namespace WebApiSchool.Persitences
{
    using System.ComponentModel.DataAnnotations;

    public partial class UsuarioEntity
    {
        [Key]
        [StringLength(30)]
        public string nombreUsr { get; set; }

        [StringLength(50)]
        public string nombreComp { get; set; }

        public string psw { get; set; }

        [StringLength(20)]
        public string grupoUsr { get; set; }

        [StringLength(5)]
        public string yearDefault { get; set; }

        [StringLength(1)]
        public string defaultPeriodo { get; set; }

    }
}
