using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
using TicketSystemWeb.Library.Api;
using TicketSystemWeb.Models;

namespace TicketSystemWeb.Controllers
{
    public class UserController : Controller
    {
        private APIHelper apiHelper = new APIHelper();
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> CreateUser(UserModel model)
        {
            using (HttpResponseMessage response = await apiHelper.ApiClient.PostAsJsonAsync("api/User/CreateAccount", model))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<UserModel>();
                    return View(result);
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}