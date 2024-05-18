using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Thor.Startup))]
namespace Thor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
