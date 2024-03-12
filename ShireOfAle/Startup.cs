using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShireOfAle.Startup))]
namespace ShireOfAle
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
