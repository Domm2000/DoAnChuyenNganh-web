using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Shopee.Startup))]
namespace Shopee
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
