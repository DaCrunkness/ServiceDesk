using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Web.Http;
using TicketSystemAPI.Models;
using static TicketSystemAPI.Library.DataAccess.TicketData;

namespace TicketSystemAPI.Controllers
{
    [Authorize]
    [RoutePrefix("api/Tickets")]

    public class TicketController : ApiController
    {
        
        private int ticketBase = 1000;
        private List<TicketModel> tickets = new List<TicketModel>();
        

        public TicketController()
        {
            
        }

        [Route("SetupTestTickets")]
        public void SetupTestTickets()
        {
            CreateTestTickets(1000);
           

       
        int i = 1 + 1;
        }

        [Route("CreateDefaultTicket")]
        public void CreateTicket()
        {
            int recordsCreated = SubmitTicket();
            int i = 1;
        }


        [Route("CreateTicket")]
        public void CreateTicket(TicketModel model)
        {
            int recordsCreated = SubmitTicket(User.Identity.GetUserName(), model.Summary, model.Detail);
        }

        [Route("GetAllTickets")]
        public void GetAllTickets()
        {

        }

        [Route("MyTickets")]
        public List<TicketModel> MyTickets()
        {
            // get logged in user tickets
            return new List<TicketModel>();
        }

        [Route("ViewTicketsByGroup")]
        public List<TicketModel> ViewTicketsByGroup(string group)
        {
            // get tickets by user group
            return new List<TicketModel>();
        }

        [Route("AddNote")]
        public void AddNote(string note)
        {

        }

        [Route("ChangeTicketStatus")]
        public void ChangeTicketStatus()
        {

        }

        [Route("AssignTicket")]
        public void AssignTicket()
        {

        }

        //public TicketModel SearchForTicket(string searchInput)
        //{
        //    return new TicketModel();
        //}

        //public TicketModel FindTicketByNumber(int ticketNumber)
        //{
        //    return new TicketModel();
        //}

        private void CreateTestTickets(int testAmount)
        {
            int NUM_OF_TICKETS = testAmount;
            for (int i = 0; i < NUM_OF_TICKETS; i++)
            {
                //tickets.Add(new TicketModel((ticketBase + i), TestTicketCreator(i), TestTicketType(i), TestTicketDetail(i)));
                //tickets.Add(new TicketModel((ticketBase + i), TestTicketCreator(i), TestTicketType(i), TestTicketDetail(i)));
            }
        }

        private string TestTicketCreator(int i)
        {
            string creator = "";


            if (i % 2 == 0)
            {
                creator += "Developer";

            }
            else if (i % 3 == 0)
            {
                creator += "System 7777";
            }
            else if (i % 2 == 0 && i % 3 == 0)
            {
                creator += "Error 8888";
            }

            return creator;
        }

        private string TestTicketType(int i)
        {
            string ticketType = "";

            if (i % 2 == 0)
            {
                ticketType += "User";

            }
            else if (i % 3 == 0)
            {
                ticketType += "System";
            }
            else
            {
                ticketType += "Error";
            }

            return ticketType;
        }

        private string TestTicketDetail(int i)
        {
            string ticketDetail = "";

            if (i % 2 == 0)
            {
                ticketDetail += "User created ticket for such situation";

            }
            else if (i % 3 == 0)
            {
                ticketDetail += "Ticket created by System Id 7777";
            }
            else
            {
                ticketDetail += "Error code, reason phrase";
            }

            return ticketDetail;
        }
    }
}
