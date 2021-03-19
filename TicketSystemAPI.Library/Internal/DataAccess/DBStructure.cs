using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemAPI.Library.Internal.DataAccess
{
    internal class DBStructure
    {
        public const string DBNAME = "LiveTickets";
        public const string USER_LOOKUP = "dbo.spUserLookup";
        public const string USER_CREATION = "dbo.spUserCreation";
        public const string USER_LOADUSERS = "dbo.spUserLoad";
        public const string USER_GETUSERGROUP = "dbo.spUser_GetUserGroup";
        public const string ERROR_INSERTNEW = "dbo.spError_InsertNew";
        public const string ERROR_LOOKUP = "dbo.spError_LookUp";
        public const string ERROR_NEWTICKET = "dbo.spError_NewTicket";
        public const string ERROR_CANAUTTOASSIGN = "dbo.spError_CanAutoAssign";
        public const string FILE_ADDTODB = "dbo.spFile_AddToDB";
        public const string SUBMIT_TICKET = "dbo.spSubmitTicket";
        public const string TICKETS_LOADALL= "dbo.spTickets_LoadAll";
        public const string TICKETS_LOADBYTYPE= "dbo.spTickets_LoadByType";
        public const string TICKETS_GETMINE= "dbo.spTickets_GetMine";
    }
}
