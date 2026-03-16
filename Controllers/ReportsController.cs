using Microsoft.AspNetCore.Mvc;

namespace EnterpriseMvcApp.Controllers
{
    public class ReportsController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Module"] = "Reports";
            ViewData["Page"] = "Reports";

            return View();
        }
    }
}