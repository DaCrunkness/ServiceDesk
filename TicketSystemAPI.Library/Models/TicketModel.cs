using System;

namespace TicketSystemAPI.Library.Models
{
    public class TicketModel
    {
        public int TicketNumber { get; set; } = 3;
        public string Creator { get; set; } = "rell";
        public string Type { get; set; } = "Test";
        public bool HasAttachment { get; set; } = false;
        public string UsersGroup { get; set; } = "Developer";
        public string Summary { get; set; } = "Test Ticket";
        public string Detail { get; set; } = "A test ticket to make sure things are connecting properly";
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public string LastModified { get; set; } = $"By: tester at {DateTime.UtcNow}.";

    }
}
