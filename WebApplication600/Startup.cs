using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication600.Startup))]
namespace WebApplication600
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
