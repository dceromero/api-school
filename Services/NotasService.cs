using System.Collections.Generic;
using WebApiSchool.Entitys;
using WebApiSchool.Requests;

namespace WebApiSchool.Services
{
    public interface NotasService
    {
        void saveNota(List<ReqSaveNota> save);

        List<OtherNoteEntity> getOtherNote(string codPlanilla, string usuario);

        void SaveOtherNote(List<ReqSaveOtherNote> req);
    }
}
