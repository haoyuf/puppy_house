using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ISEM_551.Startup))]
namespace ISEM_551
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
