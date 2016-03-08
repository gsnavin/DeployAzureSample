using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DeployAzureSample.Startup))]
namespace DeployAzureSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
