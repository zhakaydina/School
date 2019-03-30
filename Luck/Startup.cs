using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Luck.Startup))]
namespace Luck
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
