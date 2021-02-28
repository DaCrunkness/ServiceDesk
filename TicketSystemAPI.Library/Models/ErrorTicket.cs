using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystemAPI.Library.AbstractBases;
using TicketSystemAPI.Library.Helpers;

namespace TicketSystemAPI.Library.Models
{
    public class ErrorTicket : Ticket //, IErrorHelper
    {
        public int Code { get;  set; }
        public string  ErrorType { get; set; }

        public string Phrase { get; set; }

        public string Message { get; set; }

        public ErrorTicket()
        {
           
        }

        public ErrorTicket(ErrorModel error)
        {
            Code = error.Code;
            ErrorType = error.Type;
            Phrase = error.Phrase;
            Message = error.Message;
           //WillAutoAssign = CanAutoAssign();
        }

        public ErrorTicket(ErrorModel error, Ticket ticket)
        {
            Code = error.Code;
            ErrorType = error.Type;
            Phrase = error.Phrase;
            Message = error.Message;
            //WillAutoAssign = CanAutoAssign();
        }

        public void ProcessError()
        {
            throw new NotImplementedException();
        }

        //public override bool CanAutoAssign()
        //{
        //    return true;
        //}
    }
}
