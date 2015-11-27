using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DhammaStore.Startup))]
namespace DhammaStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
