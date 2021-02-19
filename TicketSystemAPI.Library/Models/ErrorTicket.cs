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
        public string Code { get;  set; }

        public string Phrase { get; set; }

        public string Message { get; set; }
        public bool CanAutoAssign { get; set; }
        int IErrorHelper.Code { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void ProcessError()
        {
            throw new NotImplementedException();
        }
    }
}
