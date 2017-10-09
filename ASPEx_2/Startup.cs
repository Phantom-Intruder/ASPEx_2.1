using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPEx_2.Startup))]
namespace ASPEx_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
