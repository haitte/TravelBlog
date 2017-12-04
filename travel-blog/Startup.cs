using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(travel_blog.Startup))]
namespace travel_blog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
