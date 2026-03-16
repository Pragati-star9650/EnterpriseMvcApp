using Microsoft.AspNetCore.Mvc;

namespace EnterpriseMvcApp.Controllers
{
    public class ProductionController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Module"] = "Production";
            ViewData["Category"] = "Production Documents";
            ViewData["Page"] = "Production";

            return View();
        }

        public IActionResult BillOfMaterials()
        {
            ViewData["Module"] = "Production";
            ViewData["Category"] = "Production Documents";
            ViewData["Page"] = "Bill Of Materials";

            return View();
        }

        public IActionResult ProductionOrder()
        {
            ViewData["Module"] = "Production";
            ViewData["Category"] = "Production Documents";
            ViewData["Page"] = "Production Order";

            return View();
        }

        public IActionResult Receipt()
        {
            ViewData["Module"] = "Production";
            ViewData["Category"] = "Production Documents";
            ViewData["Page"] = "Receipt From Production";

            return View();
        }

        public IActionResult Issue()
        {
            ViewData["Module"] = "Production";
            ViewData["Category"] = "Production Documents";
            ViewData["Page"] = "Issue For Production";

            return View();
        }
    }
}