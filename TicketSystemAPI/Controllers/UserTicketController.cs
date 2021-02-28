using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static TicketSystemAPI.Library.DataAccess.UTData;

namespace TicketSystemAPI.Controllers
{
    [Authorize]
    [RoutePrefix("api/UserTickets")]
    public class UserTicketController : ApiController
    {
        [Route("CreateTicket/{summary}/{details}")]
        public void CreateTicket(string summary, string details)
        {
            SubmitTicket(User.Identity.GetUserName(), summary, details);
        }
    }
}
