using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Comp2007_S2016_Lesson10.Startup))]
namespace Comp2007_S2016_Lesson10
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
