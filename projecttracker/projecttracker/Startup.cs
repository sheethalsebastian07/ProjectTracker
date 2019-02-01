using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(projecttracker.Startup))]
namespace projecttracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
