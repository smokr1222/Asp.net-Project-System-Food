
using systemFood.UnitofWork.Interface;

namespace systemFood.Controllers
{
    public class OrderItemController : Controller
    {
        private readonly IUnitOfWorkServices _UnitOfWorkServices;
        public OrderItemController(IUnitOfWorkServices unitOfWorkServices)
        {
            _UnitOfWorkServices = unitOfWorkServices;
        }
        public IActionResult Index()
        {
            var OrderItemLists= _UnitOfWorkServices.OrderItemSevice.GetOrderItemList();
           
            return View(OrderItemLists);
        }
    }
}
