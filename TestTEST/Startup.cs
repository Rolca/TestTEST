using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestTEST.Startup))]
namespace TestTEST
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
