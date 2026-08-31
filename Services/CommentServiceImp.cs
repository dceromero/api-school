
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using WebApiSchool.Persitences;
using WebApiSchool.Requests;
using WebApiSchool.Responses;

namespace WebApiSchool.Services
{
    public class CommentServiceImp : CommentService
    {
        private readonly ComentarioRep _repository;

        public CommentServiceImp(ComentarioRep repository)
        {
            _repository = repository;
        }
        public List<RespComment> GetRepList(ReqFindComment findComment)
        {
            return _repository.GetRepList(findComment);
        }

        public List<RespComment> SaveComment(ReqSaveComment saveComment)
        {
            _repository.SaveComment(saveComment);
            ReqFindComment findComment = new ReqFindComment()
            {
                grado = saveComment.grado,
                grupo = saveComment.grupo,
                periodo = saveComment.periodo,
            };

            return _repository.GetRepList(findComment);
        }
    }
}