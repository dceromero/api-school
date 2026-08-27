
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using WebApiSchool.Entitys;

namespace WebApiSchool.Persitences
{
    public class ContenidoResImp : ContenidoRep
    {
        private readonly ModelSchool _context;

        public ContenidoResImp()
        {
            _context = new ModelSchool();
        }
        public List<ContenidoEntity> GetContentById(int id)
        {
            string tsql = $"select * from B3Contenidos where id ='{id}'";
            return _context.Database.SqlQuery<ContenidoEntity>(tsql).ToList();
        }

        public bool SaveContent(ContenidoEntity contenido)
        {
            StringBuilder tsql = new StringBuilder($"update B3Contenidos set contenido ='{contenido.contenido}', comentario ='{contenido.comentario}', ");
            tsql.Append($"fecRegistro ='{DateTime.Now.ToString("yyyy-MM-dd")}', usuario='{contenido.usuario}' ");
            tsql.Append($"Where id='{contenido.id}' and item='{contenido.item}'");
            return _context.Database.ExecuteSqlCommand(tsql.ToString()) > 0;
        }
    }
}