using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TicketSystemAPI.Models;
using static TicketSystemAPI.Library.DataAccess.FileData;

namespace TicketSystemAPI.Controllers
{
    [RoutePrefix("api/FileHandler")]
    public class FileHandlerController : ApiController
    {
        [Route("AddFileInfoToDB")]
        public void AddFileInfo(FileModel model)
        {
            int fileAdded = AddFileToDatabase(model.Name, model.Extension, model.Path, model.Type);


            //AddFileInfoToDB(model.Name, model.Extension, model.Path, model.Type);
        }
    }
}
