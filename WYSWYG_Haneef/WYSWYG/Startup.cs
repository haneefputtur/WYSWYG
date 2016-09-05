using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WYSWYG.Startup))]
namespace WYSWYG
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
