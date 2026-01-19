using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiSchool.Persitences;
using WebApiSchool.Requests;

namespace WebApiSchool.Services
{
    public class NotasServiceImp : NotasService
    {
        private readonly NotasRep _notasRep;

        public NotasServiceImp( NotasRep notasRep)
        {
            _notasRep = notasRep;
        }
        public void saveNota(ReqSaveNota save)
        {
            _notasRep.saveNota(save);
        }
    }
}