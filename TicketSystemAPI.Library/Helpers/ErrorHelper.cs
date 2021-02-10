using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystemAPI.Library.Models;

namespace TicketSystemAPI.Library.Helpers
{
    public class ErrorHelper
    {
        public static ErrorModel ProcessError()
        {
            return new ErrorModel();
        }

        public static List<ErrorModel> GetErrorList()
        {
            return new List<ErrorModel>();
        }

        public static void AssignTicket()
        {
            
        }
    }
}
