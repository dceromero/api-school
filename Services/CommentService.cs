using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiSchool.Requests;
using WebApiSchool.Responses;

namespace WebApiSchool.Services
{
    public interface CommentService
    {
        List<RespComment> GetRepList(ReqFindComment findComment);
        List<RespComment> SaveComment(ReqSaveComment saveComment);
    }
}
