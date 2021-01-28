using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicketSystemWeb.Models
{
    public class FileModel
    {
        public string Name { get; set; }
        public string Extension { get; set; }
        public string Type { get; set; }
        public string Path { get; set; }
        public string FileString { get; set; }
    }
}