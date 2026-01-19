using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiSchool.Requests;

namespace WebApiSchool.Services
{
    public interface NotasService
    {
        void saveNota(ReqSaveNota save);
    }
}
