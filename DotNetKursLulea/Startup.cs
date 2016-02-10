using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DotNetKursLulea.Startup))]
namespace DotNetKursLulea
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
