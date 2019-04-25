using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCtarea.Startup))]
namespace MVCtarea
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
