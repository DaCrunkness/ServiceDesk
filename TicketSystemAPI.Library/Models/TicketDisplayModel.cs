using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemAPI.Library.Models
{
    public class TicketDisplayModel
    {
        public string TicketNumber { get; set; }
        public string MyProperty { get; set; }
        public string Summary { get; set; }
        public string Detail { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
