using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CBC_EMS.Startup))]
namespace CBC_EMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
