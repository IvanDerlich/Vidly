using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DatabaseCodeFirst.Startup))]
namespace DatabaseCodeFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
