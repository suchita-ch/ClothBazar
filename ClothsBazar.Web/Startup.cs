using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClothsBazar.Web.Startup))]
namespace ClothsBazar.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
