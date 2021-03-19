using TicketSystemAPI.Library.AbstractBases;

namespace TicketSystemAPI.Library.Models
{
    public class UserTicket : Ticket
    {
        public string Team { get; set; }
        public string Agency { get; set; }
        public string Role { get; set; }
        public UserTicket()
        {

        }
    }
}