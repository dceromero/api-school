using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using WebApiSchool.Requests;

namespace WebApiSchool.Persitences
{
    public class NotasRepImp : NotasRep
    {
        private readonly ModelSchool _context;
        public NotasRepImp(ModelSchool context)
        {
            _context = context;
        }
        public void saveNota(ReqSaveNota req)
        {
            StringBuilder tsql = new StringBuilder($"update B1SeguimientosNt set n1 ='{req.n1}', n2 ='{req.n2}', n3='{req.n3}', n4='{req.n4}' ");
            tsql.AppendLine($"where idmatricula = {req.idmatricula} and idPlanilla = {req.idPlanilla} and CodLogro = '{req.CodLogro}'");
            _context.Database.ExecuteSqlCommand(tsql.ToString());
        }
    }
}