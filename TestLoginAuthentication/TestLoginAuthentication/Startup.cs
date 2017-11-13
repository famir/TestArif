using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestLoginAuthentication.Startup))]
namespace TestLoginAuthentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
