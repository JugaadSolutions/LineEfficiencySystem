using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LineEfficiencySystem.Startup))]
namespace LineEfficiencySystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
