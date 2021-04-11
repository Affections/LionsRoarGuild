using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LionsRoarGuild.Startup))]
namespace LionsRoarGuild
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
