using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodeFromDatabase.Startup))]
namespace CodeFromDatabase
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
