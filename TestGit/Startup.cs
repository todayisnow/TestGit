using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestGit.Startup))]
namespace TestGit
{
    public partial class Startup
    {//b1
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
