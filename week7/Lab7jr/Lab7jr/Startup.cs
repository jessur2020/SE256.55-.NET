using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab7jr.Startup))]
namespace Lab7jr
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
