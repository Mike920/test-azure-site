using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP_Tut.Startup))]
namespace ASP_Tut
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
