using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiSchool.Persitences;
using WebApiSchool.Responses;

namespace WebApiSchool.Services
{
    public class MenuServiceImp: MenuService
    {
        private readonly MenuRep repository;

        public MenuServiceImp(MenuRep repository)
        {
            this.repository = repository;
        }

        public List<RespMenu> GetMenuByUserGroup(string grupoUsr)
        {
            var menuEntities = repository.GetMenuByUserGroup(grupoUsr);
            var respMenus = menuEntities.Where(me => me.tipoOp == "_M" && me.nodoPadre ==0)
                .Select(me => new RespMenu
                {
                    Opcion = me.opcion,
                    Descripcion = me.descripcion,
                    subMenu = menuEntities
                        .Where(se => se.nodoPadre == me.secuencia && se.tipoOp == "O")
                        .Select(se => new RespSubMenu
                        {
                            Opcion = se.opcion,
                            Descripcion = se.descripcion,
                        }).ToList()
                }).ToList();
            return respMenus;
        }
    }
}