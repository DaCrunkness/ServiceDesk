using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystemAPI.Library.Helpers;
using TicketSystemAPI.Library.Models;

namespace TicketSystemAPI.Library.AbstractBases
{
    public abstract class Ticket 
    {
        public int TicketNumber { get; set; }
        public string Creator { get; set; }
        public string Type { get; set; }
        public bool HasAttachment { get; set; }
        public string Status { get; set; }
        public string UsersGroup { get; set; }
        public string Summary { get; set; }
        public string Detail { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastModified { get; set; }


    }
}
