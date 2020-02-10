using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StoreRater.Startup))]
namespace StoreRater
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
