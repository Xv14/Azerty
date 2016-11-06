using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PiX.GUI.Startup))]
namespace PiX.GUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
