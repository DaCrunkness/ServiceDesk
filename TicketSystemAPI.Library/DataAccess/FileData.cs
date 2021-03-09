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
        public static void AddFileToDatabase(string fileName, string fileEXT, string filePath, string fileType)
        {
            SqlDataAccess sql = new SqlDataAccess();
            var p = new { Name = fileName, Extension = fileEXT, Path = filePath, Type = fileType };
            sql.SaveData(DBStructure.FILE_ADDTODB, p, DBStructure.DBNAME);
        }

        
    }
}
