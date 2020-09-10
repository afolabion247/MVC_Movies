using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_FinalProject.Startup))]
namespace MVC_FinalProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
