
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using WebApiSchool.Requests;
using WebApiSchool.Responses;

namespace WebApiSchool.Persitences
{
    public interface ComentarioRep
    {
        List<RespComment> GetRepList(ReqFindComment findComment);
        bool SaveComment(ReqSaveComment saveComment);
    }
}