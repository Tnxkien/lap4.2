using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lap4.Startup))]
namespace lap4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
