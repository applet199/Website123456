using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Website123456.Startup))]
namespace Website123456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
