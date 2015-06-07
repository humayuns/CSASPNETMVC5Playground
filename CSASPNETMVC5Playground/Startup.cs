using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CSASPNETMVC5Playground.Startup))]
namespace CSASPNETMVC5Playground
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
