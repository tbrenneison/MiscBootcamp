using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(painanddisappointment.Startup))]
namespace painanddisappointment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
