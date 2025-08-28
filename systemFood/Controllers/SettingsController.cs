

namespace systemFood.Controllers
{
    public class SettingsController : Controller
    {
        private readonly IProductRepository _RebostryProduct;
        public SettingsController(IProductRepository rebostryProduct)
        {
            _RebostryProduct = rebostryProduct;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult MineProduct()
        {
            var find= _RebostryProduct.GetProductAndCategoryData();
            return View(find);
        }

        public IActionResult MineProfile()
        {
            return View();
        }
        public IActionResult MineExtras()
        {
            var find = _RebostryProduct.GetProductAndCategoryData();
            return View(find);
        }


    }
}
