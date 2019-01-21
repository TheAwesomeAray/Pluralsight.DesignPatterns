using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVPDemo.Startup))]
namespace MVPDemo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
