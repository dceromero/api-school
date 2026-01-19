using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using WebApiSchool.Requests;

namespace WebApiSchool.Persitences
{
    public interface NotasRep
    {
        void saveNota(ReqSaveNota req);
    }
}