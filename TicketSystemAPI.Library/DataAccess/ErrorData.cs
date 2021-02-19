using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystemAPI.Library.Internal.DataAccess;
using TicketSystemAPI.Library.Models;

namespace TicketSystemAPI.Library.DataAccess
{
    public class ErrorData
    {
        public static void AddError(int code, string type, string phrase, string message, bool autoAssigns)
        {
            ErrorModel data = new ErrorModel
            {
                Code = code, 
                Type = type, 
                Phrase = phrase, 
                Message = message, 
                WillAutoAssign = autoAssigns
            };

            string sql = @"insert into dbo.Errors (Code, Type, Phrase, Message, WillAutoAssign)
                                         values (@Code, @Type, @Phrase, @Message, @WillAutoAssign);";
           SqlDataAccess.SaveData(sql, data);
        }
    }
}
