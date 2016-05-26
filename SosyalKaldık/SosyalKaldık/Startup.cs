using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SosyalKaldık.Startup))]
namespace SosyalKaldık
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
