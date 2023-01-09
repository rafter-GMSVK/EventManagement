using Microsoft.AspNetCore.Mvc;

namespace EventManagement.Controllers
{
    public class EventController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
