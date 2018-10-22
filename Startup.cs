using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Burngym.Startup))]
namespace Burngym
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
