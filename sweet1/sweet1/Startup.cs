using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sweet1.Startup))]
namespace sweet1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
