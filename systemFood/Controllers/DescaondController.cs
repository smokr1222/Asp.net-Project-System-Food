


using systemFood.UnitofWork.Interface;

namespace systemFood.Controllers
{
    public class DescaondController : Controller
    {
        private const string CartSessionKey = "ProductIds";



        private readonly IUnitOfWorkServices _UnitOfWorkServices;
        public DescaondController(IUnitOfWorkServices unitOfWorkServices)
        {
            _UnitOfWorkServices = unitOfWorkServices;
        }


    
        public IActionResult Index()
        {
            return View();
        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DescandTotal(string Descaond)
        {
            // يتم حفظ بيانات مؤقته في عمل برنامج 
            var SessionDescaond = HttpContext.Session.GetObject<OrderModel>(CartSessionKey);
            decimal total = 0;
            //جمع جميع المنتجات كاملة
            total =(decimal)SessionDescaond.items.Sum(x => x.Quantity*x.Price);
            // هنا يتم عمليه الخصم سعر منتج
            SessionDescaond.TotalAmount = (double)_UnitOfWorkServices.DescaondService.GetDescaondOpertionForBusinessLogic(Descaond, total);
            HttpContext.Session.SetObject(CartSessionKey, SessionDescaond);

            return RedirectToAction("Index", "Home");

        }




    }
}
