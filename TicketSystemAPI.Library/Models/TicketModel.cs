using System;

namespace TicketSystemAPI.Library.Models
{
    public class TicketModel
    {
        public int TicketNumber { get; set; }
        public string Creator { get; set; }
        public string Type { get; set; }
        public byte[] Attachment { get; set; }
        public string Group { get; set; }
        public string Summary { get; set; } = "A type ticket for group name";
        public string Detail { get; set; } = "This ticket comes from with these stats";
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public string LastModified { get; set; }
    }
}
