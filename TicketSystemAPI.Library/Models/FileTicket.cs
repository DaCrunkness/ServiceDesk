using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystemAPI.Library.AbstractBases;

namespace TicketSystemAPI.Library.Models
{
    public class FileTicket : Ticket
    {
        public string Name { get; set; }
        public string Extention { get; set; }
        public string Path { get; set; }
        public string FileType { get; set; }
        public string Source { get; set; }
        public FileTicket(int ticketNumber, string creator, string type, bool hasAttachment, string status, string userGroup, string summary, string detail, DateTime createdDate, string lastModified)
            : base(ticketNumber, creator, type, hasAttachment, status, userGroup, summary, detail, createdDate, lastModified)
        {

        }
    }
}
