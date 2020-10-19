using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebColorinAPP.Startup))]
namespace WebColorinAPP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
