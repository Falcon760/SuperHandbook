using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SuperHandbook.Startup))]
namespace SuperHandbook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
