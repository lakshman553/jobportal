using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jobportal_beta.Startup))]
namespace jobportal_beta
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
