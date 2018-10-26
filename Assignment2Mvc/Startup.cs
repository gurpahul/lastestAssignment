using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignment2Mvc.Startup))]
namespace Assignment2Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
