using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FBComment.Startup))]
namespace FBComment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
