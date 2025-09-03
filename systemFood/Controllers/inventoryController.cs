using Microsoft.AspNetCore.Mvc;

namespace systemFood.Controllers
{
    public class inventoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {

            return View();

        }

    }
}
