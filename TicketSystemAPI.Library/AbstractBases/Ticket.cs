using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystemAPI.Library.Helpers;
using TicketSystemAPI.Library.Models;

namespace TicketSystemAPI.Library.AbstractBases
{
    public abstract class Ticket : ITicketHelper
    {
        private int ticketNumber;
        private bool hasAttachment;
        private DateTime createdData;
        private string creator, type, userGroup, summary, detail, lastModified;

        public int TicketNumber { get => throw new NotImplementedException(); private set => throw new NotImplementedException(); }
        public string Creator { get => throw new NotImplementedException(); private set => throw new NotImplementedException(); }
        public string Type { get => throw new NotImplementedException(); private set => throw new NotImplementedException(); }
        public bool HasAttachment { get => throw new NotImplementedException(); private set => throw new NotImplementedException(); }
        public string UsersGroup { get => throw new NotImplementedException(); private set => throw new NotImplementedException(); }
        public string Summary { get => throw new NotImplementedException(); private set => throw new NotImplementedException(); }
        public string Detail { get => throw new NotImplementedException(); private set => throw new NotImplementedException(); }
        public DateTime CreatedDate { get => throw new NotImplementedException(); private set => throw new NotImplementedException(); }
        public string LastModified { get => throw new NotImplementedException(); private set => throw new NotImplementedException(); }

        enum TicketType
        {
            User, Error, File 
        }

        public Ticket(TicketModel model)
        {
            ticketNumber = TicketNumber;
        }

        

        // ticket type
        // has attachment
        // user group
    }
}
