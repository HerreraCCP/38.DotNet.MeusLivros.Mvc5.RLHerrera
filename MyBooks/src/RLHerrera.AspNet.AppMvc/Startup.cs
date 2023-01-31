using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RLHerrera.AspNet.AppMvc.Startup))]
namespace RLHerrera.AspNet.AppMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
