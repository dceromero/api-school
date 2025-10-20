using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiSchool.Entitys;

namespace WebApiSchool.Persitences
{
    public interface MenuRep
    {
        List<MenuEntity> GetMenuByUserGroup(string grupoUsr);
    }
}