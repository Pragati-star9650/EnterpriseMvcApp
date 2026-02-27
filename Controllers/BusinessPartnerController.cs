using Microsoft.AspNetCore.Mvc;

namespace EnterpriseMvcApp.Controllers
{
    public class BusinessPartnerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MasterData()
        {
            return View();
        }

        public IActionResult Contacts()
        {
            return View();
        }
    }
}

