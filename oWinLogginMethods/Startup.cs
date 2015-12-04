using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(oWinLogginMethods.Startup))]
namespace oWinLogginMethods
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
