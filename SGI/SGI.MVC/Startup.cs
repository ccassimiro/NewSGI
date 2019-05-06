using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SGI.MVC.Startup))]
namespace SGI.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
