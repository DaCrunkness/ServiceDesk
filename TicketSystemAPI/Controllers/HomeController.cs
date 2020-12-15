using System.Web.Mvc;

namespace TicketSystemAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Api Home";

            return View();
        }
    }
}
