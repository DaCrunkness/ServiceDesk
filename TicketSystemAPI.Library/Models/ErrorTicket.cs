using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystemAPI.Library.AbstractBases;
using TicketSystemAPI.Library.Helpers;

namespace TicketSystemAPI.Library.Models
{
    public class ErrorTicket : Ticket, IErrorHelper
    {
        public int Code { get;  set; }

        public string Phrase { get; set; }

        public string Message { get; set; }
        public bool CanAutoAssign { get; set; }

        public ErrorTicket(int ticketNumber, string creator, string type, bool hasAttachment, string status, string userGroup, string summary, string detail, DateTime createdDate, string lastModified)
            :base(ticketNumber, creator, type, hasAttachment, status, userGroup, summary, detail, createdDate, lastModified)
        {
           
        }

        public void ProcessError()
        {
            throw new NotImplementedException();
        }
    }
}
