using System.Collections.Generic;
using System.Linq;
using TicketSystemAPI.Library.AbstractBases;
using TicketSystemAPI.Library.Internal.DataAccess;
using TicketSystemAPI.Library.Models;

namespace TicketSystemAPI.Library.DataAccess
{
    public class TicketData
    {
        public static int SubmitTicket()
        {
            TicketModel data = new TicketModel();
            data.TicketNumber = GetTicketNumber();

            string sql = @"insert into dbo.Tickets (TicketNumber, Creator, Type, HasAttachment, UsersGroup, Summary, Detail, LastModified)
                                         values (@TicketNumber, @Creator, @Type, @HasAttachment, @UsersGroup, @Summary, @Detail, @LastModified);";
            return SqlDataAccess.SaveData(sql, data);
        }
        public static int SubmitTicket(string creator, string summary, string detail)
        {
            TicketModel data = new TicketModel
            {
                TicketNumber = GetTicketNumber(), 
                Creator = creator,
                Summary = summary,
                Detail = detail, 

            };

            string sql = @"insert into dbo.Tickets (TicketNumber, Creator, Type, HasAttachment, UsersGroup, Summary, Detail, LastModified)
                                         values (@TicketNumber, @Creator, @Type, @HasAttachment, @UsersGroup, @Summary, @Detail, @LastModified);";
            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<TicketModel> LoadTickets()
        {
            string sql = @"select TicketNumber, Creator, Summary, Detail, CreateDate from dbo.Tickets;";

            return SqlDataAccess.LoadData<TicketModel>(sql);
        }


        public static List<Ticket> LoadTickets(string userGroup)
        {
            string sql = $"select TicketNumber, Creator, Summary, Detail, CreateDate from dbo.Tickets where UsersGroup = { userGroup };";

            return SqlDataAccess.LoadData<Ticket>(sql);
        }

        public static List<TicketModel> GetNumberOfTickets()
        {
            string sql = @"select COUNT(TicketNumber) from dbo.Tickets;"; // Try againg with stored procedures

            return SqlDataAccess.LoadData<TicketModel>(sql);
        }

        private static int GetTicketNumber()
        {
            var data = LoadTickets();
            int ticketNumber = data.Count + 1;
            return ticketNumber;
        }
    }
}