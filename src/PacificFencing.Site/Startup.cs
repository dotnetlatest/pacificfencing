using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PacificFencing.Site.Startup))]
namespace PacificFencing.Site
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
