using Microsoft.AspNet.Identity;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
using TicketSystemWeb.Library.Api;
using TicketSystemWeb.Models;

namespace TicketSystemWeb.Controllers
{
    [Authorize]
    public class TicketController : Controller
    {
        private APIHelper apiHelper = new APIHelper();
        // GET: Ticket
        public ActionResult Index()
        {
            return View();
        }

        // POST: Ticket/Create
        [HttpPost]
        public async Task<ActionResult> CreateTicket(TicketModel model)
        {
            model.Creator = User.Identity.GetUserName();
            using (HttpResponseMessage response = await apiHelper.ApiClient.PostAsJsonAsync("api/Ticket/CreateTicket", model))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<TicketModel>();
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