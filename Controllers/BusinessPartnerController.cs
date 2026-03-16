using Microsoft.AspNetCore.Mvc;

namespace EnterpriseMvcApp.Controllers
{
    public class BusinessPartnerController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Module"] = "Business Partner";
            ViewData["Category"] = "Master Data";
            ViewData["Page"] = "Business Partner";

            return View();
        }

        public IActionResult MasterData()
        {
            ViewData["Module"] = "Business Partner";
            ViewData["Category"] = "Master Data";
            ViewData["Page"] = "Master Data";

            return View();
        }

        public IActionResult Contacts()
        {
            ViewData["Module"] = "Business Partner";
            ViewData["Category"] = "Master Data";
            ViewData["Page"] = "Contacts";

            return View();
        }
    }
}