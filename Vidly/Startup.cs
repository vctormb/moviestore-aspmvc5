using Microsoft.Owin;
using Owin;
using Vidly;

[assembly: OwinStartup(typeof(Startup))]
namespace Vidly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
