using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ApplicationGroupWork.Startup))]
namespace ApplicationGroupWork
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
