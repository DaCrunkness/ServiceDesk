using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicketSystemAPI.Models
{
    public class ErrorReport
    {
        public string ErrorId { get; set; }
        public string ErrorType { get; set; }
        public string ErrorDescription { get; set; }
        public string ErrorSource { get; set; }
    }
}


