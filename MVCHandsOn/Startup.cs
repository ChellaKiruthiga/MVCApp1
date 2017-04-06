using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCHandsOn.Startup))]
namespace MVCHandsOn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
