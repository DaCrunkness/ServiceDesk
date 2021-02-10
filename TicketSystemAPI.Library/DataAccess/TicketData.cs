using System.Collections.Generic;
using TicketSystemAPI.Library.Internal.DataAccess;
using TicketSystemAPI.Library.Models;

namespace TicketSystemAPI.Library.DataAccess
{
    public class TicketData
    {
        public static int SubmitTicket(int ticketNumber, string creator, string summary, string detail)
        {
            TicketModel data = new TicketModel
            {
                TicketNumber = ticketNumber, 
                Creator = creator,
                Summary = summary,
                Detail = detail
            };

            string sql = @"insert into dbo.Tickets (TicketNumber, Creator, Summary, Detail)
                                         values (@TicketNumber, @Creator, @Summary, @Detail);";
            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<TicketModel> LoadTickets()
        {
            string sql = @"select TicketNumber, Creator, Summary, Detail, CreateDate from dbo.Tickets;";

            return SqlDataAccess.LoadData<TicketModel>(sql);
        }

        public static int GetTicketNumber()
        {
            var data = LoadTickets();
            int ticketNumber = data.Count + 1001;
            return ticketNumber;
        }
    }
}