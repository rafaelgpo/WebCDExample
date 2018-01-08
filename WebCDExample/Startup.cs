using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebCDExample.Startup))]
namespace WebCDExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
