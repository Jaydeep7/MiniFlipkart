using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MiniFlipkart.Startup))]
namespace MiniFlipkart
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
