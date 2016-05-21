using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IServiceApp.Startup))]
namespace IServiceApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
