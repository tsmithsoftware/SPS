using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DriverSystem.Startup))]
namespace DriverSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
