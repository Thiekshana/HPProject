using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DengfuTesting.Startup))]
namespace DengfuTesting
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
