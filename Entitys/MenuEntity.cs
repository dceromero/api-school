using System.ComponentModel.DataAnnotations;

namespace WebApiSchool.Entitys
{
    public class MenuEntity
    {
        [Key]
        public string opcion { get; set; }
        public string descripcion { get; set; }
        public int nodoPadre { get; set; }
        public string tipoOp { get; set; }
        public int secuencia { get; set; }


    }
}