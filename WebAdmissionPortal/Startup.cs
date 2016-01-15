using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAdmissionPortal.Startup))]
namespace WebAdmissionPortal
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
