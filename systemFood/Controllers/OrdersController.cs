


using systemFood.UnitofWork.Interface;

namespace systemFood.Controllers
{
    public  class OrdersController : Controller
    {     
        private readonly IUnitOfWorkServices _UnitOfWorkServices;
        public OrdersController(IUnitOfWorkServices unitOfWorkServices)
        {
            _UnitOfWorkServices = unitOfWorkServices;
        }
        private const string CartSessionKey = "ProductIds";
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SaveOrder()
        {
            var SessionOrder = HttpContext.Session.GetObject<OrderModel>(CartSessionKey); 
            await _UnitOfWorkServices.OrderService.SaveOrderServr(SessionOrder);
            await _UnitOfWorkServices.ProductService.UpdateProductStock(SessionOrder);
            HttpContext.Session.Remove(CartSessionKey);
            return RedirectToAction("Index","Home");

        }



    }
}
