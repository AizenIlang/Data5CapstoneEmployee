using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Data5CapstoneEmployee.Startup))]
namespace Data5CapstoneEmployee
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
