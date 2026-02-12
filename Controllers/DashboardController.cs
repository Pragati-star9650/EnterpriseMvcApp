using Microsoft.AspNetCore.Mvc;

namespace EnterpriseMvcApp.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            // Protect page
            if (HttpContext.Session.GetString("UserName") == null)
            {
                return RedirectToAction("Login", "Account");
            }

            return View();
        }
    }
}

