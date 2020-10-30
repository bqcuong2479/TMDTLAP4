using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lap04.Startup))]
namespace Lap04
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
