using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(catmovieapp.Startup))]
namespace catmovieapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
