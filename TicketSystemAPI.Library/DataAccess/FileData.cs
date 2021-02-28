using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystemAPI.Library.Internal.DataAccess;
using TicketSystemAPI.Library.Models;

namespace TicketSystemAPI.Library.DataAccess
{
    public class FileData
    {
        private const string TICKET_TYPE = "File";
        public static int AddFileToDatabase(string fileName, string fileEXT, string filePath, string fileType)
        {
            FileModel data = new FileModel
            {
                Name = fileName,
                Extension = fileEXT,
                Path = filePath,
                Type = fileType
            };

            string sql = @"insert into dbo.FileInfo (Name, Extension, Path, Type)
                                         values (@Name, @Extension, @Path, @Type);";
            return SqlDataAccess.SaveData(sql, data);
        }

        public List<FileModel> GetFileById(int Id)
        {
            string sql = $"select * from dbo.FileInfo where Id = { Id };";
            return SqlDataAccess.LoadData<FileModel>(sql);

        }
        public static List<FileModel> LoadData()
        {
            string sql = @"select Name, Extension, Type, Path from dbo.FileInfo;";

            return SqlDataAccess.LoadData<FileModel>(sql);
        }


        private static List<FileTicket> LoadTicketNumberByType(string type)
        {
            string sql = $"select TicketNumber, Creator, WillAutoAssign, Summary, Detail, CreateDate from dbo.Tickets where Type = { type };";

            return SqlDataAccess.LoadData<FileTicket>(sql);
        }

        private static string GetTicketNumber()
        {
            var data = LoadTicketNumberByType(TICKET_TYPE);
            int number = data.Count + 1;
            string ticketNumber = $"F{number}";
            return ticketNumber;
        }

        //private static int SubmitTicket(ErrorModel error, string creator, string userGroup)
        //{

        //    ErrorTicket data = new ErrorTicket
        //    {
        //        TicketNumber = GetTicketNumber(),
        //        Creator = creator,
        //        Type = TICKET_TYPE,
        //        WillAutoAssign = CanAutoAssign(error.Code),
        //        UsersGroup = userGroup,
        //        Summary = error.Phrase,
        //        Detail = error.Message,
        //        LastModified = DateTime.Now.ToString(),
        //        Code = error.Code,
        //        ErrorType = error.Type,
        //        Phrase = error.Phrase,
        //        Message = error.Message
        //    };


        //    string sql = @"insert into dbo.Tickets (TicketNumber, Creator, Type, HasAttachment, WillAutoAssign, Status, UsersGroup, Summary, Detail, LastModified)
        //                                 values (@TicketNumber, @Creator, @Type, @HasAttachment @WillAutoAssign, @Status, @UsersGroup, @Summary, @Detail, @LastModified);";
        //    return SqlDataAccess.SaveData(sql, data);
        //}
    }
}
