using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicketSystemAPI.Models
{
    public class TicketModel
    {
        public int TicketNumber { get; set; }
        public string Creator { get; set; }
        public string Summary { get; set; }
        public string Detail { get; set; }
        public byte[] Attachment { get; set; }
    }
}