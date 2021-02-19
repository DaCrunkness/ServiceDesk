using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TicketSystemAPI.Models;
using static TicketSystemAPI.Library.DataAccess.ErrorData;

namespace TicketSystemAPI.Controllers
{
    [Authorize]
    [RoutePrefix("api/Errors")]
    public class ErrorsController : ApiController
    {
        [Route("NewError")]
        public void CreateErrorType(ErrorModel model)
        {
            AddError(model.Code, model.Type, model.Phrase, model.Message, model.WillAutoAssign);
        }
    }
}
