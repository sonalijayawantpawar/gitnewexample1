using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gitnewexample.Startup))]
namespace gitnewexample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
