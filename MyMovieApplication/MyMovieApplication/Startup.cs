using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyMovieApplication.Startup))]
namespace MyMovieApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
