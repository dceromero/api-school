namespace WebApiSchool.Persitences
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class UsuarioEntity
    {
        [Key]
        [StringLength(30)]
        public string nombreUsr { get; set; }

        [StringLength(50)]
        public string nombreComp { get; set; }   
        
        public string password { get; set; }

        [StringLength(20)]
        public string grupoUsr { get; set; }

        
    }
}
