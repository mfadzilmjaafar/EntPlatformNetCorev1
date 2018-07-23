using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EntPlatform.Web.Startup))]
namespace EntPlatform.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
