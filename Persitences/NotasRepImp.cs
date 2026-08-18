using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApiSchool.Entitys;
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
        private void saveNotaOne(ReqSaveNota req)
        {
            StringBuilder tsql = new StringBuilder($"update B1SeguimientosNt set n1 ='{req.n1}', n2 ='{req.n2}', n3='{req.n3}', n4='{req.n4}' ");
            tsql.AppendLine($"where idmatricula = {req.idmatricula} and idPlanilla = {req.idPlanilla} and CodLogro = '{req.CodLogro}'");
            ModelSchool modelSchool = new ModelSchool();
            modelSchool.Database.ExecuteSqlCommand(tsql.ToString());
        }
        public void saveNota(List<ReqSaveNota> req)
        {
            req.AsParallel().ForAll(x => saveNotaOne(x));
        }

        public List<OtherNoteEntity> getOtherNote(string codPlanilla, string usuario)
        {
            string sqlGetOtherNote = $"exec Pr_getListaOtr '{codPlanilla}','{usuario}','webApi' ";
            return _context.Database.SqlQuery<OtherNoteEntity>(sqlGetOtherNote).ToList();
        }

        private void SaveOtherNoteOne(ReqSaveOtherNote req)
        {
            StringBuilder tsql = new StringBuilder($"update B1SeguimientosOtr set Ausencias ='{req.ausencias}', NotaRP ='{req.notaRp}', NotaRF='{req.notaRF}', NotaNiv='{req.notaNiv}' ");
            tsql.AppendLine($", NotaEU='{req.notaEU}', NIcfes='{req.nIcfes}' ");
            tsql.AppendLine($"where idmatricula = {req.idMatricula} and idPlanilla = {req.idPlanilla} ");
            ModelSchool modelSchool = new ModelSchool();
            modelSchool.Database.ExecuteSqlCommand(tsql.ToString());
        }

        public void SaveOtherNote(List<ReqSaveOtherNote> req)
        {
            req.AsParallel().ForAll(x => SaveOtherNoteOne(x));
        }
    }
}