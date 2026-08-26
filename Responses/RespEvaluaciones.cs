using System;

namespace WebApiSchool.Entitys
{
public class RespEvaluaciones
{
    public int id { get; set; }
    public string item { get; set; }
    public string idEvaluacion { get; set; }
    public string evaluacion { get; set; }
    public string detalle { get; set; }
    public DateTime? fecha { get; set; }
}
}
