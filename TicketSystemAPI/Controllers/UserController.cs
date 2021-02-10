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
    public class UserController : ApiController
    {
        [HttpPost]
        [Route("CreateAccount")]
        public void CreateAccount(UserModel model)
        {
            int recordsCreated = CreateUser(model.FirstName, model.LastName, model.PhoneNumber, model.EmailAddress, model.UsersGroup);
        }

        [HttpGet]
        [Route("ViewProfile")]
        public UserModel ViewProfile(string Id)
        {
            return GetUserById(Id).First();
        }

        [HttpGet]
        [Route("ViewGroup")]
        public List<UserModel> ViewGroup(string group)
        {
            return GetUserGroup(group);
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