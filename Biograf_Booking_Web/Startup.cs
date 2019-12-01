using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Biograf_Booking_Web.Startup))]
namespace Biograf_Booking_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
