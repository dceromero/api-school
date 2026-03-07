using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using WebApiSchool.Entitys;
using WebApiSchool.Requests;

namespace WebApiSchool.Persitences
{
    public interface NotasRep
    {
        void saveNota(List<ReqSaveNota> req);
        List<OtherNoteEntity> getOtherNote(string codPlanilla, string usuario);
        void SaveOtherNote(List<ReqSaveOtherNote> otherNote);
    }
}