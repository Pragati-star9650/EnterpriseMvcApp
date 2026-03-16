using System.Diagnostics;
using EnterpriseMvcApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace EnterpriseMvcApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        /*public IActionResult Index()
        {
            return RedirectToAction("Index", "Dashboard");
        }
        */
        public IActionResult Privacy()
{
    ViewData["Module"] = "Home";
    ViewData["Page"] = "Privacy";

    return View();
}

[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
public IActionResult Error()
{
    ViewData["Module"] = "Home";
    ViewData["Page"] = "Error";

    return View(new ErrorViewModel
    {
        RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
    });
}
}
}