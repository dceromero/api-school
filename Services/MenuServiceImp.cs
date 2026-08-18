using System.Collections.Generic;
using System.Linq;
using WebApiSchool.Persitences;
using WebApiSchool.Responses;

namespace WebApiSchool.Services
{
    public class MenuServiceImp : MenuService
    {
        private readonly MenuRep repository;

        public MenuServiceImp(MenuRep repository)
        {
            this.repository = repository;
        }

        public List<RespMenu> GetMenuByUserGroup(string grupoUsr)
        {
            var menuEntities = repository.GetMenuByUserGroup(grupoUsr);
            var respMenus = menuEntities.Where(me => me.tipoOp == "_M" && me.nodoPadre == 0)
                .Select(me => new RespMenu
                {
                    Opcion = me.opcion,
                    Descripcion = me.descripcion,
                    Icon = me.iconOption,
                    subMenu = menuEntities
                        .Where(se => se.nodoPadre == me.secuencia && se.tipoOp == "_DLG")
                        .Select(se => new RespSubMenu
                        {
                            Opcion = se.opcion,
                            Descripcion = se.descripcion,
                            Url = se.urlOption,
                            Icon = se.iconOption
                        }).ToList()
                }).ToList();
            return respMenus;
        }
    }
}