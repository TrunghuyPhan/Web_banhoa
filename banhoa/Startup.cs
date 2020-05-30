using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(banhoa.Startup))]
namespace banhoa
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
