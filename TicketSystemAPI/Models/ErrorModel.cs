using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicketSystemAPI.Models
{
    public class ErrorModel
    {
        public int Code { get; set; }
        public string Type { get; set; }
        public string Phrase { get; set; }
        public string Message { get; set; }
        public bool WillAutoAssign { get; set; }
    }
}