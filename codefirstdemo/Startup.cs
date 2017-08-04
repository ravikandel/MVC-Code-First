using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(codefirstdemo.Startup))]
namespace codefirstdemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
