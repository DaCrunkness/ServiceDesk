namespace TicketSystemWeb.Models
{
    public class TicketModel
    {
        public int Id { get; set; }
        public int TicketNumber { get; set; } = 1;
        public string Creator { get; set; } = "A developer";
        public string Summary { get; set; }
        public string Detail { get; set; }
        public string CreateDate { get; set; }
        public byte[] Attachment { get; set; }
    }
}