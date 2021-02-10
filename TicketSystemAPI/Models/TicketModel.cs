using System;

namespace TicketSystemAPI.Models
{
    public class TicketModel
    {
        public int TicketNumber { get; set; }
        public string Creator { get; set; }
        public string Type { get; set; }
        public bool HasAttachment { get; set; } = false;
        public string Group { get; set; }
        public string Summary { get; set; } = "A type ticket for group name";
        public string Detail { get; set; } = "This ticket comes from with these stats";
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public string LastModified { get; set; } = "By: User at " + DateTime.UtcNow;


        public TicketModel(int ticketNumber, string creator, string summary, string detail)
        {
            this.TicketNumber = ticketNumber;
            this.Creator = creator;
            this.Summary = summary;
            this.Detail = detail;
        }
    }
}