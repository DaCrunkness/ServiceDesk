using System;

namespace TicketSystemAPI.Library.AbstractBases
{
    public abstract class Ticket 
    {
        public string TicketNumber { get; set; }
        public string Creator { get; set; }
        public string UsersGroup { get; set; }
        public string Type { get; set; }
        public string Status { get; set; } = "Open";
        public string Summary { get; set; }
        public string Detail { get; set; }
        public string CreatedDate { get; set; }
        public string LastModified { get; set; }
        public bool HasAttachment { get; set; } = false;
        public string AttachString { get; set; }
        public string WillAutoAssign { get; set; }
        public bool CanAutoAssign { get; set; } = false;
        public string AutoAssignString { get; set; }

        public bool IsAssigned { get; set; } = false;
        public string AssignedString { get; set; }

        public bool IsResolved { get; set; } = false;
        public string ResolvedString { get; set; }

        public string AssignedTo { get; set; } = "None";
        public string AssignedBy { get; set; } = "System";

        public Ticket()
        {

        }

        //public Ticket()
        //{
        //    TicketNumber = GenerateTicketNumber();
        //    Creator = GetTicketCreator();
        //    Type = DetermineType();
        //    HasAttachment = AreAttachments();
        //    WillAutoAssign = CanAutoAssign();
        //    Status = CurrentStatus();
        //    UsersGroup = GetUserGroup();
        //    Summary = UpdateSummary();
        //    Detail = UpdateDetails();
        //    CreatedDate = ViewDateCreated();
        //    LastModified = UpdateLastModifiied();
        //}

        //public Ticket(int ticketNumber, string creator, string type, bool hasAttachment, string status, string userGroup, string summary, string detail, DateTime createdDate, string lastModified)
        //{
        //    TicketNumber = ticketNumber;
        //    Creator = creator;
        //    Type = type;
        //    HasAttachment = hasAttachment;
        //    Status = status;
        //    UsersGroup = userGroup;
        //    Summary = summary;
        //    Detail = detail;
        //    CreatedDate = createdDate;
        //    LastModified = lastModified;
        //}

        public virtual string GenerateTicketNumber() { return "D1000"; }
        public virtual string GetTicketCreator() { return "DevTeam"; }
        public virtual string DetermineType() { return "Test"; }
        public virtual bool AreAttachments() { return false; }
        public virtual bool CheckCanAutoAssign() { return false; }
        public virtual string CurrentStatus() { return "Open"; }
        public virtual string GetUserGroup() { return "Admin"; }
        public virtual string UpdateSummary() { return "Test Ticket"; }
        public virtual string UpdateDetails() { return "A blank test ticket"; }
        public virtual string ViewDateCreated() { return "Today"; }
        public virtual string UpdateLastModifiied(string name) { return $"{ name } {DateTime.Now}"; }
        public virtual string HasAttatchmentString(bool hasAttachment) { return hasAttachment ? "true" : "false"; }
        public virtual bool HasAttatchmentToBool(string hasAttachment) { return hasAttachment == "true" ? true : false; }
        public virtual string WillAutoAssignString(bool willAutoAssign) { return  willAutoAssign ? "true" : "false"; }
        public virtual bool WillAutoAssignToBool(string willAutoAssign) { return  willAutoAssign == "true" ? true : false; }
        public virtual string IsAssignedString(bool isAssigned) { return isAssigned ? "true" : "false"; }
        public virtual bool IsAssignedToBool(string isAssigned) { return isAssigned == "true" ? true : false; }
        public virtual string IsResolvedString(bool isResolved) { return isResolved ? "true" : "false"; }
        public virtual bool IsResolvedToBool(string isResolved) { return isResolved == "true" ? true : false; }
    }
}