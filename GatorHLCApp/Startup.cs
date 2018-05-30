using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GatorHLCApp.Startup))]
namespace GatorHLCApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
