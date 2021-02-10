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
            int recordsCreated = SubmitTicket(GetTicketNumber(), model.Creator, model.Summary, model.Detail);
        }

        public void GetAllTickets()
        {

        }

        public List<TicketModel> MyTickets()
        {
            // get logged in user tickets
            return new List<TicketModel>();
        }

        public List<TicketModel> ViewTicketsByGroup(string group)
        {
            // get tickets by user group
            return new List<TicketModel>();
        }

        public void AddNote(string note)
        {

        }

        public void ChangeTicketStatus()
        {

        }

        public void AssignTicket()
        {

        }

        public TicketModel SearchForTicket(string searchInput)
        {
            return new TicketModel();
        }

        public TicketModel FindTicketByNumber(int ticketNumber)
        {
            return new TicketModel();
        }
    }
}
