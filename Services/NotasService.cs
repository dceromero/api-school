using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
