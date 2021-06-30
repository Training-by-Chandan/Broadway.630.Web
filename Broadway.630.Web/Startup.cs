using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Broadway._630.Web.Startup))]
namespace Broadway._630.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
