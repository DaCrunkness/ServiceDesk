using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemAPI.Library.Models
{
    public class ErrorModel
    {
        public int Code { get; set; }
        public string Type { get; set; }
        public string Phrase { get; set; }
        public string Message { get; set; }
        public string WillAutoAssign { get; set; }
    }
}
