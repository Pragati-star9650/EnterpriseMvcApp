using Microsoft.AspNetCore.Mvc;

namespace EnterpriseMvcApp.Controllers
{
    public class InventoryController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Module"] = "Inventory";
            ViewData["ModuleController"] = "Inventory";
            ViewData["Category"] = "Inventory Transactions";
            ViewData["Page"] = "Inventory";

            return View();
        }

        public IActionResult Items()
        {
            ViewData["Module"] = "Inventory";
            ViewData["ModuleController"] = "Inventory";
            ViewData["Category"] = "Inventory Transactions";
            ViewData["Page"] = "Items";

            return View();
        }

        public IActionResult GoodsReceipt()
        {
            ViewData["Module"] = "Inventory";
            ViewData["ModuleController"] = "Inventory";
            ViewData["Category"] = "Inventory Transactions";
            ViewData["Page"] = "Goods Receipt";

            return View();
        }

        public IActionResult GoodsIssue()
        {
            ViewData["Module"] = "Inventory";
            ViewData["ModuleController"] = "Inventory";
            ViewData["Category"] = "Inventory Transactions";
            ViewData["Page"] = "Goods Issue";

            return View();
        }

        public IActionResult Transfers()
        {
            ViewData["Module"] = "Inventory";
            ViewData["ModuleController"] = "Inventory";
            ViewData["Category"] = "Inventory Transactions";
            ViewData["Page"] = "Inventory Transfers";

            return View();
        }
    }
}