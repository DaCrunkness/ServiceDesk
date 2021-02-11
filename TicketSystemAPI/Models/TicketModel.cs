using System;

namespace TicketSystemAPI.Models
{
    public class TicketModel
    {
        //public int TicketNumber { get; set; }
        //public string Creator { get; set; }
        //public string Type { get; set; }
        //public bool HasAttachment { get; set; } = false;
        //public string Group { get; set; }
        public string Summary { get; set; }
        public string Detail { get; set; }
        //public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        //public string LastModified { get; set; } = "By: User at " + DateTime.UtcNow;


        public TicketModel(string summary, string detail)
        {
            
            this.Summary = summary;
            this.Detail = detail;
        }
    }
}