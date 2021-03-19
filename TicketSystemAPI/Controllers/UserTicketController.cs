using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TicketSystemAPI.Library.Models;
using TicketSystemAPI.Models;
using static TicketSystemAPI.Library.DataAccess.UTData;

namespace TicketSystemAPI.Controllers
{
    [Authorize]
    [RoutePrefix("api/UserTickets")]
    public class UserTicketController : ApiController
    {
        [Route("CreateTicket")]
        public void CreateTicket(Models.UserTicket ticket)
        {
            SubmitTicket(User.Identity.GetUserName(), ticket.Summary, ticket.Detail);
        }

        [Route("MyTickets")]
        public List<TicketDisplayModel> MyTickets()
        {
            return GetMyTickets(User.Identity.GetUserName());
        }
    }
}
