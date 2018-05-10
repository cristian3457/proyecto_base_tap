using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VISTA_WEB.Startup))]
namespace VISTA_WEB
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
