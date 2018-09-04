using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CropCalendar.Startup))]
namespace CropCalendar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
