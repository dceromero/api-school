
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using WebApiSchool.Requests;
using WebApiSchool.Responses;

namespace WebApiSchool.Persitences
{
    internal class ComentarioRepImp : ComentarioRep
    {
        private readonly ModelSchool _context;

        public ComentarioRepImp()
        {
            _context = new ModelSchool();
        }
        public List<RespComment> GetRepList(ReqFindComment findComment)
        {
            StringBuilder tsql = new StringBuilder( $"Select * from QB1ComentariosNt ");
            tsql.Append($"where ano =dbo.Fnc_Defano() and periodo ='{findComment.periodo}' and ");
            tsql.Append($"grado ='{findComment.grado}' and grupo ='{findComment.grupo}' ");
            tsql.Append("order by apellidos, nombres");
            return _context.Database.SqlQuery<RespComment>(tsql.ToString()).ToList();
        }

        public bool SaveComment(ReqSaveComment saveComment)
        {
            StringBuilder tsql = new StringBuilder($"update B1Comentariosnt set comentario = '{saveComment.comentario}' ");
            tsql.Append($"where ano =dbo.Fnc_Defano() and periodo ='{saveComment.periodo}' and idmatricula ='{saveComment.idmatricula}'");
            return _context.Database.ExecuteSqlCommand(tsql.ToString()) > 0;
        }
    }
}