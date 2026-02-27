using Microsoft.AspNetCore.Mvc;

namespace EnterpriseMvcApp.Controllers
{
    public class AdministrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CompanySetup()
        {
            return View();
        }

        public IActionResult Users()
        {
            return View();
        }

        public IActionResult Authorizations()
        {
            return View();
        }

        public IActionResult DocumentNumbering()
        {
            return View();
        }

        public IActionResult GeneralSettings()
        {
            return View();
        }
    }
}

