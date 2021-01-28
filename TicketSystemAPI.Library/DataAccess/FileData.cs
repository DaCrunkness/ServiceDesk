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

        public List<FileModel> GetFileById(string Id)
        {
            string sql = $"select * from dbo.FileInfo where Id = { Id };";
            return SqlDataAccess.LoadData<FileModel>(sql);

        }
        public static List<FileModel> LoadData()
        {
            string sql = @"select Name, Extension, Type, Path from dbo.FileInfo;";

            return SqlDataAccess.LoadData<FileModel>(sql);
        }
    }
}
