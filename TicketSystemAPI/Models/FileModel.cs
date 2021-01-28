using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicketSystemAPI.Models
{
    public class FileModel
    {
        /// <summary>
        /// Name of file
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Extension for file
        /// </summary>
        public string Extension { get; set; }

        /// <summary>
        /// Full path for file
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Type of file, text, audio, image, etc..
        /// </summary>
        public string Type { get; set; }

    }
}