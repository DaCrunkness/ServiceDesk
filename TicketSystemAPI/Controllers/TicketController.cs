using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Web.Http;
using TicketSystemAPI.Models;
using static TicketSystemAPI.Library.DataAccess.TicketData;

namespace TicketSystemAPI.Controllers
{
    
    [RoutePrefix("api/Ticket")]
    public class TicketController : ApiController
    {
        [Route("CreateTicket")]
        public void CreateTicket(TicketModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Attachment == null)
                {
                    int recordsCreated = SubmitTicket(GetTicketNumber(), model.Creator, model.Summary, model.Detail);
                }
                else
                {
                    int recordsCreated = SubmitTicket(GetTicketNumber(), User.Identity.GetUserName(), model.Summary, model.Detail, model.Attachment);
                }
            }
        }

        public void GetAllTickets()
        {

        }
    }
}
