using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystemAPI.Library.Models;

namespace TicketSystemAPI.Library.Helpers
{
    public interface IErrorHelper
    {
        int Code { get; set; }
        string Type { get; set; }
        string Phrase { get; set; }
        string Message { get; set; }
        bool CanAutoAssign { get; set; }
        void ProcessError();
    }
}
