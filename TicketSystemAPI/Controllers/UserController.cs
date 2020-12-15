using System.Web.Http;
using TicketSystemAPI.Library.Models;
using static TicketSystemAPI.Library.DataAccess.UserData;

namespace TicketSystemAPI.Controllers
{
    public class UserController : ApiController
    {
        [Route("CreateAccount")]
        public void CreateAccount(UserModel model)
        {
            int recordsCreated = CreateUser(model.FirstName, model.LastName, model.PhoneNumber, model.EmailAddress);
        }
    }
}