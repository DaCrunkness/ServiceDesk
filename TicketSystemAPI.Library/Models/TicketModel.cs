using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemAPI.Library.Models
{
    public class TicketModel
    {
        public int Id { get; set; }
        public int TicketNumber { get; set; }
        public string Creator { get; set; }
        public string Summary { get; set; }
        public string Detail { get; set; }
        public byte[] Attachment { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    }
}
