using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TicketSystemWeb.Startup))]
namespace TicketSystemWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
