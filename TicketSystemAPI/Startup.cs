using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(TicketSystemAPI.Startup))]

namespace TicketSystemAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
