using System.Collections.Generic;
using WebApiSchool.Entitys;
using WebApiSchool.Persitences;
using WebApiSchool.Requests;

namespace WebApiSchool.Services
{
    public class NotasServiceImp : NotasService
    {
        private readonly NotasRep _notasRep;

        public NotasServiceImp(NotasRep notasRep)
        {
            _notasRep = notasRep;
        }

        public List<OtherNoteEntity> getOtherNote(string codPlanilla, string usuario)
        {
            return _notasRep.getOtherNote(codPlanilla, usuario);
        }

        public void saveNota(List<ReqSaveNota> save)
        {
            _notasRep.saveNota(save);
        }

        public void SaveOtherNote(List<ReqSaveOtherNote> req)
        {
            _notasRep.SaveOtherNote(req);
        }
    }
}