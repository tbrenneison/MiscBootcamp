using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(hopefullyfinaltestapp.Startup))]
namespace hopefullyfinaltestapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
