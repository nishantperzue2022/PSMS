using Microsoft.AspNetCore.Mvc;
using MvcApplication.BLL.Repositories.MemberModule;
using MvcApplication.BLL.Repositories.MvcModule;
using MvcApplication.BLL.Repositories.SchemeModule;
using MvcApplication.DTO.MvcModule;

namespace MvcApplication.Controllers
{
    public class GenerateMvcController : Controller
    {
        private readonly ISchemeRepository schemeRepository;

        private readonly IMemberRepository memberRepository;
        public GenerateMvcController(IMemberRepository memberRepository, ISchemeRepository schemeRepository)
        {
            this.schemeRepository = schemeRepository;

            this.memberRepository = memberRepository;
        }
        public async Task<IActionResult> Index(string MemberNo, decimal SchemeNo)
        {
            try
            {
                ViewBag.Schemes = await schemeRepository.GetAll();

                return View();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                TempData["Error"] = "Something went wrong ,please contact system admin for assistance";

                return RedirectToAction("Login", "Account", new { area = "" });
            }
        }


        public async Task<IActionResult> SearchMember(string MemberNo, decimal SchemeNo)
        {
            try
            {
                var results = await memberRepository.GetByMemberNo(MemberNo, SchemeNo);

                if (results != null)
                {
                    return Json(new { data = results });
                }
                else
                {
                    return Json(new { success = false, responseText = "Unable to search member" });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return null;
            }
        }

        public async Task<IActionResult> GenerateMVC(MemberDTO mvcMemberDTO)
        {
            try
            {
                var results = await memberRepository.GenerateMVC(mvcMemberDTO);

                if (results != null)
                {
                    return Json(new { success = true, responseText = "Mvc No " + results.MvcNumber + " has been generated for " + results.MemberName + " in " + results.Department + " at " + DateTime.Now + " valid for next 4 hours" });
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
