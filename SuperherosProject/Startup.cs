using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SuperherosProject.Startup))]
namespace SuperherosProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
