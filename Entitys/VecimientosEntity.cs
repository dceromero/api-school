using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace WebApiSchool.Entitys
{
    public class VecimientosEntity
    {
        public string nombreUsr { get; set; }
        public string codGrado { get; set; }
        public string descGrado { get; set; }
        public string codAsignatura { get; set; }
        public string asignatura { get; set; }
        public string fechaVigencia { get; set; }
        public int periodo { get; set; }
        public int cantLogros { get; set; }
        public int cantNotasIng { get; set; }

    }
}