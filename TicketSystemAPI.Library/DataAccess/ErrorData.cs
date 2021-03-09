using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystemAPI.Library.AbstractBases;
using TicketSystemAPI.Library.Internal.DataAccess;
using TicketSystemAPI.Library.Models;

namespace TicketSystemAPI.Library.DataAccess
{
    public class ErrorData
    {
        private const string TICKET_TYPE = "Error"; 
        public static void AddError(int code, string type, string phrase, string message, bool autoAssigns)
        {
            SqlDataAccess sql = new SqlDataAccess();
            var p = new { Code = code, Type = type, Phrase = phrase, Message = message, WillAutoAssign = autoAssigns.ToString() };
            sql.SaveData(DBStructure.ERROR_INSERTNEW, p, DBStructure.DBNAME);
        }

        public static ErrorModel GetError(int code)
        {
            SqlDataAccess sql = new SqlDataAccess();
            var p = new { Code = code };
            var output = sql.LoadData<ErrorModel, dynamic>(DBStructure.ERROR_LOOKUP, p, DBStructure.DBNAME);
            return output.First();
        }

        public static void SubmitTicket(ErrorModel error, string creator, string userGroup)
        {
            SqlDataAccess sql = new SqlDataAccess();
            var p = new { TicketNumber = GetTicketNumber(), Creator = creator, Type = TICKET_TYPE, UsersGroup = userGroup,
                Summary = error.Phrase, Detail = error.Message, LastModified = DateTime.Now.ToString() };
            sql.SaveData(DBStructure.SUBMIT_TICKET, p, DBStructure.DBNAME);
        }

        private static string CanAutoAssign(int code)
        {
            SqlDataAccess sql = new SqlDataAccess();
            var p = new { Code = code };
            var output = sql.LoadData<ErrorModel, dynamic>(DBStructure.ERROR_CANAUTTOASSIGN, p, DBStructure.DBNAME);
            return output.First().WillAutoAssign;
        }

        public static string GetUserGroup(string emailAddress)
        {
            SqlDataAccess sql = new SqlDataAccess();
            var p = new { EmailAddress = emailAddress };
            var output = sql.LoadData<UserModel, dynamic>(DBStructure.USER_GETUSERGROUP, p, DBStructure.DBNAME);
            return output.First().UsersGroup;
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
            string ticketNumber = $"E{number}";
            return ticketNumber;
        }

        private static string GetUsersFullName(string emailAddress)
        {
            string fullName = "";
            string sql = $";";
            return fullName;
        }
    }
}
