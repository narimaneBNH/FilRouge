using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FilRouge.web.Startup))]
namespace FilRouge.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
