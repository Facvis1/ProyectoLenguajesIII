using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoLenguajesIII.Startup))]
namespace ProyectoLenguajesIII
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
