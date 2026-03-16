using Microsoft.AspNetCore.Mvc;

namespace EnterpriseMvcApp.Controllers
{
    public class AdministrationController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Module"] = "Administration";
            ViewData["Category"] = "System Setup";
            ViewData["Page"] = "Administration";

            return View();
        }

        public IActionResult CompanySetup()
        {
            ViewData["Module"] = "Administration";
            ViewData["Category"] = "System Setup";
            ViewData["Page"] = "Company Setup";

            return View();
        }

        public IActionResult Users()
        {
            ViewData["Module"] = "Administration";
            ViewData["Category"] = "System Setup";
            ViewData["Page"] = "Users";

            return View();
        }

        public IActionResult Authorizations()
        {
            ViewData["Module"] = "Administration";
            ViewData["Category"] = "System Setup";
            ViewData["Page"] = "Authorizations";

            return View();
        }

        public IActionResult DocumentNumbering()
        {
            ViewData["Module"] = "Administration";
            ViewData["Category"] = "System Setup";
            ViewData["Page"] = "Document Numbering";

            return View();
        }

        public IActionResult GeneralSettings()
        {
            ViewData["Module"] = "Administration";
            ViewData["Category"] = "System Setup";
            ViewData["Page"] = "General Settings";

            return View();
        }
    }
}