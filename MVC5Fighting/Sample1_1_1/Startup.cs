using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sample1_1_1.Startup))]
namespace Sample1_1_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
