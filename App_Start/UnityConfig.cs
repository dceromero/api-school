using System.Web.Http;
using Unity;
using Unity.WebApi;
using WebApiSchool.Persitences;
using WebApiSchool.Services;

namespace WebApiSchool
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<UsuarioRep, UsuarioRepImp>();
            container.RegisterType<UsuarioService, UsuarioServiceImp>();

            container.RegisterType<MenuRep, MenuRepImp>();
            container.RegisterType<MenuService, MenuServiceImp>();

            container.RegisterType<VencimientosRep, VencimientosRepImp>();
            container.RegisterType<VencimientosService, VencimientosServiceImp>();

            container.RegisterType<LogrosRep, LogrosRepImp>();
            container.RegisterType<LogroService, LogroServiceImp>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}