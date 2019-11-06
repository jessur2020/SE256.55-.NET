using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab6Jr.Startup))]
namespace Lab6Jr
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
