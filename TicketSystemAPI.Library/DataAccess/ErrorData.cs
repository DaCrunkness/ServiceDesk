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
            ErrorModel data = new ErrorModel
            {
                Code = code, 
                Type = type, 
                Phrase = phrase, 
                Message = message, 
                WillAutoAssign = autoAssigns.ToString()
            };

            string sql = @"insert into dbo.Errors (Code, Type, Phrase, Message, WillAutoAssign)
                                         values (@Code, @Type, @Phrase, @Message, @WillAutoAssign);";
           SqlDataAccess.SaveData(sql, data);
        }

        //public static void ReportError(int code)
        //{
        //    var error = GetError(code).First();
        //    ErrorModel data = new ErrorModel
        //    {
                
        //    };

        //    string sql = $"select Code, Type, Phrase, Message from dbo.Errors where Code = { code };";
        //    SqlDataAccess.SaveData(sql, data);
        //}
        
        public static ErrorModel GetError(int code)
        {
            string sql = $"select Code, Type, Phrase, Message from dbo.Errors where Code = { code };";
            List<ErrorModel> data =  SqlDataAccess.LoadData<ErrorModel>(sql);
            return data.First();
        }

        public static int SubmitTicket(ErrorModel error, string creator, string userGroup)
        {

            ErrorTicket data = new ErrorTicket
            {
                TicketNumber = GetTicketNumber(), 
                Creator = creator,
                Type = TICKET_TYPE,
                WillAutoAssign = CanAutoAssign(error.Code),
                UsersGroup = userGroup,
                Summary = error.Phrase, 
                Detail = error.Message,
                LastModified = DateTime.Now.ToString(),
                Code = error.Code, 
                ErrorType = error.Type, 
                Phrase = error.Phrase, 
                Message = error.Message
            };

            

            string sql = @"insert into dbo.Tickets (TicketNumber, Creator, UsersGroup, Type, Status, Summary, Detail, LastModified)
                                         values (@TicketNumber, @Creator, @UsersGroup, @Type, @Status, @Summary, @Detail, @LastModified);";
            return SqlDataAccess.SaveData(sql, data);
        }

        // private string WillAutoAssignString(bool willAutoAssign) { return willAutoAssign ? "true" : "false"; }

        private static string CanAutoAssign(int code)
        {
            string sql = $"select WillAutoAssign from dbo.Errors where Code = '{ code }';";
            List<ErrorModel> data = SqlDataAccess.LoadData<ErrorModel>(sql);
            return data.First().WillAutoAssign;
        }

        public static List<ErrorTicket> LoadTickets()
        {
            string sql = @"select TicketNumber, Creator, Summary, Detail, CreateDate from dbo.Tickets;";

            return SqlDataAccess.LoadData<ErrorTicket>(sql);
        }

        public static string GetUserGroup(string emailAddress)
        {
            string sql = $"select UsersGroup from dbo.Users where EmailAddress = '{ emailAddress }';";
            List<UserModel> users = SqlDataAccess.LoadData<UserModel>(sql);
            return users.First().UsersGroup;
        }


        private static List<ErrorTicket> LoadTicketNumberByType(string type)
        {
            string sql = $"select TicketNumber from dbo.Tickets where Type = '{ type }';";
            return SqlDataAccess.LoadData<ErrorTicket>(sql);
        }
        
        private static string GetTicketNumber()
        {
            var data = LoadTicketNumberByType(TICKET_TYPE);
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
