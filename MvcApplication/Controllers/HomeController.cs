using Microsoft.AspNetCore.Mvc;
using MvcApplication.BLL.Repositories.MvcModule;

namespace MvcApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IMvcRepository mvcRepository;

        public HomeController(IMvcRepository mvcRepository,ILogger<HomeController> logger)
        {
            _logger = logger;

            this.mvcRepository = mvcRepository;
        }

        public async Task<IActionResult> Index(decimal HospitalCode)
        {
            try
            {
                var listOfMvcs = await mvcRepository.GetMvc(HospitalCode);

                return View(listOfMvcs);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                TempData["Error"] = "Something went wrong ,please contact system admin for assistance";

                return RedirectToAction("Login", "Account", new { area = "" });
            }
        }

    }
}