using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystemAPI.Library.Internal.DataAccess;
using TicketSystemAPI.Library.Models;

namespace TicketSystemAPI.Library.DataAccess
{
    public class UTData
    {
        private const string TICKET_TYPE = "User";

        public static void SubmitTicket(string creator, string summary, string details)
        {
            SqlDataAccess sql = new SqlDataAccess();
            var p = new
            {
                TicketNumber = GetTicketNumber(),
                Creator = creator,
                Type = TICKET_TYPE,
                UsersGroup = GetUserGroup(creator),
                Summary = summary,
                Detail = details,
                LastModified = DateTime.Now.ToString()
            };
            sql.SaveData(DBStructure.SUBMIT_TICKET, p, DBStructure.DBNAME);
            
        }

        private static List<ErrorTicket> LoadTicketsByType(string type)
        {
            SqlDataAccess sql = new SqlDataAccess();
            var p = new { Type = type };
            var output = sql.LoadData<ErrorTicket, dynamic>(DBStructure.TICKETS_LOADBYTYPE, p, DBStructure.DBNAME);
            return output;
        }

        private static string GetTicketNumber()
        {
            var data = LoadTicketsByType(TICKET_TYPE);
            int number = data.Count + 1;
            string ticketNumber = $"U{number}";
            return ticketNumber;
        }

        public static string GetUserGroup(string emailAddress)
        {
            SqlDataAccess sql = new SqlDataAccess();
            var p = new { EmailAddress = emailAddress };
            var output = sql.LoadData<UserModel, dynamic>(DBStructure.USER_GETUSERGROUP, p, DBStructure.DBNAME);
            return output.First().UsersGroup;
        }
    }
}
