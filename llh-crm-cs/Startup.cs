using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(llh_crm_cs.Startup))]
namespace llh_crm_cs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
