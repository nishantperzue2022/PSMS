using Microsoft.AspNetCore.Mvc;

namespace MvcApplication.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
