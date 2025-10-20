using System.Collections.Generic;
using WebApiSchool.Responses;

namespace WebApiSchool.Services
{
    public interface MenuService
    {
        List<RespMenu> GetMenuByUserGroup(string grupoUsr);
    }
}