using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testwebappnumber27.Startup))]
namespace testwebappnumber27
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
