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

        public void ViewProfile()
        {

        }

        public void ViewGroup()
        {

        }

        public void ViewTicketPool()
        {

        }

        public void ViewMyTickets()
        {

        }

        public void ViewGroupTickets()
        {

        }

        public void UpdateUserInfo()
        {

        }

        public void ViewRole()
        {

        }


    }
}