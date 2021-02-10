using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemAPI.Library.Models
{
    public class ErrorModel
    {
        public string Code { get; set; }
        public string Type { get; set; }
        public string Phrase { get; set; }
        public string Detail { get; set; }
        public bool WillAutoAssign { get; set; }
    }
}
