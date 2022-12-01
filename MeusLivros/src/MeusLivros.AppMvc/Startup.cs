using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MeusLivros.AppMvc.Startup))]
namespace MeusLivros.AppMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
