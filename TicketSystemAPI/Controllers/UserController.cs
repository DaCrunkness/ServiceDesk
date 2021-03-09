using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using TicketSystemAPI.Library.DataAccess;
using TicketSystemAPI.Library.Models;
using static TicketSystemAPI.Library.DataAccess.UserData;

namespace TicketSystemAPI.Controllers
{
    [RoutePrefix("api/User")]
    [Authorize]
    public class UserController : ApiController
    {
        [HttpPost]
        [Route("CreateAccount")]
        public void CreateAccount(UserModel model)
        {
            CreateUser(model.FirstName, model.LastName, model.PhoneNumber, model.EmailAddress, model.UsersGroup);
        }

        [HttpGet]
        [Route("ViewProfile")]
        public UserModel ViewProfile()
        {
           return GetUserById(User.Identity.GetUserName());
        }

        [HttpGet]
        [Route("ViewGroup")]
        public void ViewGroup(string group)
        {
            // return GetUserGroup(group);
        }

        [HttpGet]
        [Route("ViewTicketPool")]
        public void ViewTicketPool()
        {

        }

        [HttpGet]
        [Route("ViewMyTickets")]
        public void ViewMyTickets()
        {

        }

        [HttpGet]
        [Route("ViewGroupTickets")]
        public void ViewGroupTickets()
        {

        }

        [HttpPatch]
        [Route("UpdateUserInfo")]
        public void UpdateUserInfo()
        {

        }

        [HttpGet]
        [Route("ViewRole")]
        public void ViewRole()
        {

        }


    }
}