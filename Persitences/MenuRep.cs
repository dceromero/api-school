using System.Collections.Generic;
using WebApiSchool.Entitys;

namespace WebApiSchool.Persitences
{
    public interface MenuRep
    {
        List<MenuEntity> GetMenuByUserGroup(string grupoUsr);
    }
}