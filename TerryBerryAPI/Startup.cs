using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(TerryBerryAPI.Startup))]

namespace TerryBerryAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
