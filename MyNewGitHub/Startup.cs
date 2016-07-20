using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyNewGitHub.Startup))]
namespace MyNewGitHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
