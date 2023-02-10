using Microsoft.AspNetCore.Mvc;

namespace MvcApplication.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
