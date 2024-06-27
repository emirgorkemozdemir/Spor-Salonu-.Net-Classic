using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Spor_Salonu.Startup))]
namespace Spor_Salonu
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
