using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SistRespBasal.Startup))]
namespace SistRespBasal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
