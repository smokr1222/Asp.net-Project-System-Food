
using systemFood.UnitofWork.Interface;
using static systemFood.ViewModel.Product.SelectProduct;

namespace systemFood.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWorkServices _UnitOfWorkServices;
        public HomeController( IUnitOfWorkServices unitOfWorkServices)
        {
            _UnitOfWorkServices = unitOfWorkServices;
        }
        private const string CartSessionKey = "ProductIds";
        public  async Task<IActionResult> Index(int Id)
        {
            if (Id==1||Id==0)
            {
                var ProductId  = _UnitOfWorkServices.ProductService.GetProductAllService();
                ViewBag.Product = ProductId;

            }
            else
            {
                var Catogryfullter = await _UnitOfWorkServices.CategoryService.GetCategoryByIdWithIProductBusinessLogic(Id);
                var productIds     = Catogryfullter.IProduct;
                ViewBag.Product    = productIds;

            }

            var Catogry      = await _UnitOfWorkServices.CategoryService.GetCategoriesForBusinessLogic();
            ViewBag.catogry  = Catogry;
            var SessionOrder = HttpContext.Session.GetObject<OrderModel>(CartSessionKey) ?? new OrderModel();


            if (SessionOrder.OrderId==null)
                SessionOrder.OrderId = _UnitOfWorkServices.OrderService.NewOrder();

            HttpContext.Session.SetObject(CartSessionKey, SessionOrder);

            return View(SessionOrder);
        }

        [HttpPost]
        public async Task<IActionResult> Selectanitem(int id)
        {
            var SessionProduct        = HttpContext.Session.GetObject<OrderModel>(CartSessionKey) ?? new OrderModel();
            if (!await _UnitOfWorkServices.MineFoodServices.SelectProductListForBusinessLogic(SessionProduct,id))
                    TempData["error"] = "·« Ì„ﬂ‰ﬂ «·ﬂ„Ì… ﬁ·Ì·…";
           


            HttpContext.Session.SetObject(CartSessionKey, SessionProduct);
            return Json(new { success = true });
        }






        [HttpPost]
        public async Task<IActionResult> DecreaseQuantity(int Id)
        {

            var SessionProduct = HttpContext.Session.GetObject<OrderModel>(CartSessionKey) ;

            if (_UnitOfWorkServices.MineFoodServices.DecreaseQuantityForBusinessLogic(SessionProduct,Id))
            {
                HttpContext.Session.SetObject(CartSessionKey, SessionProduct);
                return Json(new { success = true });

            }
            else
            {
                return NotFound();
            }

          


        }


        [HttpPost]
        public async Task<IActionResult> IncreaseQuantity(int Id)
        {

            var SessionProduct = HttpContext.Session.GetObject<OrderModel>(CartSessionKey);


            if (!_UnitOfWorkServices.MineFoodServices.IncreaseQuantityForBusinessLogic(SessionProduct, Id))
                TempData["error"] = "·« Ì„ﬂ‰ﬂ «·ﬂ„Ì… ﬁ·Ì·…";
          

            HttpContext.Session.SetObject(CartSessionKey, SessionProduct);
            return Json(new { success = true });


      
        }
        [HttpPost]
        public IActionResult TrashSelect(int Id)
        {
            var SessionProduct = HttpContext.Session.GetObject<OrderModel>(CartSessionKey);
            var Existing     = SessionProduct.items.FirstOrDefault(x => x.Id == Id);
            if (Existing != null)
            {
                SessionProduct.TotalAmount = (SessionProduct.TotalAmount - (double)Existing.TotalPrisenew);
                SessionProduct.items.Remove(Existing);
            }
                


            HttpContext.Session.SetObject(CartSessionKey, SessionProduct);
            return RedirectToAction("Index");
        }





        [HttpPost]
        public IActionResult PaymentMethod(String Payment)
        {
            var SessionProduct = HttpContext.Session.GetObject<OrderModel>(CartSessionKey);
            foreach (var item in SessionProduct.items)
            {

                if (Payment == "money")
                    item.paymentMethod = ePaymentMethod.eMoneyCach;
                else if (Payment == "CreditCard")
                    item.paymentMethod = ePaymentMethod.eCreditCard;
                else if (Payment == "visa")
                    item.paymentMethod = ePaymentMethod.VisaCard;

            }
            HttpContext.Session.SetObject(CartSessionKey, SessionProduct);
            return RedirectToAction("Index");
        }





        public IActionResult Stores()
        {

            return View();
        }











    }
}
