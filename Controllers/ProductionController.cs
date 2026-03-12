using Microsoft.AspNetCore.Mvc;

namespace EnterpriseMvcApp.Controllers
{
    public class ProductionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult BillOfMaterials()
        {
            return View();
        }

        public IActionResult ProductionOrder()
        {
            return View();
        }

        public IActionResult Receipt()
        {
            return View();
        }

        public IActionResult Issue()
        {
            return View();
        }
    }
}
