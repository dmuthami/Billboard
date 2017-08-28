using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BillboardApp.Startup))]
namespace BillboardApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
