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

        public static int SubmitTicket(string creator, string summary, string details)
        {
            UserTicket data = new UserTicket() 
            {
                TicketNumber = GetTicketNumber(),
                Creator = creator,
                Type = TICKET_TYPE,
                UsersGroup = GetUserGroup(creator),
                Summary = summary,
                Detail = details,
                LastModified = DateTime.Now.ToString()
            };

            string sql = @"insert into dbo.Tickets (TicketNumber, Creator, UsersGroup, Type, Status, Summary, Detail, LastModified)
                                         values (@TicketNumber, @Creator, @UsersGroup, @Type, @Status, @Summary, @Detail, @LastModified);";
            return SqlDataAccess.SaveData(sql, data);
        }

        private static string GetTicketNumber()
        {
            var data = LoadTicketNumberByType(TICKET_TYPE);
            int number = data.Count + 1;
            string ticketNumber = $"U{number}";
            return ticketNumber;
        }

        private static List<UserTicket> LoadTicketNumberByType(string type)
        {
            string sql = $"select TicketNumber from dbo.Tickets where Type = '{ type }';";
            return SqlDataAccess.LoadData<UserTicket>(sql);
        }

        public static string GetUserGroup(string emailAddress)
        {
            string sql = $"select UsersGroup from dbo.Users where EmailAddress = '{ emailAddress }';";
            List<UserModel> users = SqlDataAccess.LoadData<UserModel>(sql);
            return users.First().UsersGroup;
        }
    }
}
