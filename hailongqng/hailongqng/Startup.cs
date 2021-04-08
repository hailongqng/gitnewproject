using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(hailongqng.Startup))]
namespace hailongqng
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
