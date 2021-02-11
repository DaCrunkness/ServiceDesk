using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemAPI.Library.Helpers
{
    public interface ITicketHelper
    {
        int TicketNumber { get; }
        string Creator { get; }
        string Type { get; }
        bool HasAttachment { get; }
        string UsersGroup { get; }
        string Summary { get; }
        string Detail { get; } 
        DateTime CreatedDate { get; }
        string LastModified { get; }

    }
}
