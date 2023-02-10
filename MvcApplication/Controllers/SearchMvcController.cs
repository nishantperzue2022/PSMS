using Microsoft.AspNetCore.Mvc;
using MvcApplication.BLL.Repositories.MvcModule;
namespace MvcApplication.Controllers
{
    public class SearchMvcController : Controller
    {
        private readonly IMvcRepository mvcRepository;
        public SearchMvcController(IMvcRepository mvcRepository)
        {
            this.mvcRepository = mvcRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> GetMVC(decimal MvcNumber)
        {
            try
            {
                var results = await mvcRepository.GetByMvcNo(MvcNumber);

                if (results != null)
                {
                    return Json(new { data = results });
                }
                else
                {
                    return Json(new { success = false, responseText = "Unable to generate mvc" });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return null;
            }
        }
    }
}
