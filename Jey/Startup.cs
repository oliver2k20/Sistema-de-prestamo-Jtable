using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Jey.Startup))]
namespace Jey
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
