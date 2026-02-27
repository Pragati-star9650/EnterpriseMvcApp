using Microsoft.AspNetCore.Mvc;

namespace EnterpriseMvcApp.Controllers
{
    public class InventoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Items()
        {
            return View();
        }

        public IActionResult GoodsReceipt()
        {
            return View();
        }

        public IActionResult GoodsIssue()
        {
            return View();
        }

        public IActionResult Transfers()
        {
            return View();
        }
    }
}
