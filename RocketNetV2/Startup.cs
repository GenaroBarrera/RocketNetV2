using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RocketNetV2.Startup))]
namespace RocketNetV2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
