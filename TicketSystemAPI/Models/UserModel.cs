using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicketSystemAPI.Models
{
    public class UserModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    }
}