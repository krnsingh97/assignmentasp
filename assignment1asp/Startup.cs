using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(assignment1asp.Startup))]
namespace assignment1asp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
