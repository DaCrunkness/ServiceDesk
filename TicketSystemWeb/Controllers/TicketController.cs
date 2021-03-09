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
        private APIHelper _apiHelper;
        // GET: Ticket
        public ActionResult Index()
        {
            return View();
        }

        // POST: Ticket/Create
        [HttpPost]
        public async Task<ActionResult> CreateTicket(UserTicket ticket)
        {
            ReadyHelper();
            using (HttpResponseMessage response = await _apiHelper.ApiClient.PostAsJsonAsync("api/UserTickets/CreateTicket", ticket))
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

        private void ReadyHelper()
        {
            _apiHelper = new APIHelper();
            _apiHelper.AddRequestHeaders(Session["accessToken"].ToString());
        }

    }
}