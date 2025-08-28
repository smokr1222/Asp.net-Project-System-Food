
using systemFood.UnitofWork.Interface;

namespace systemFood.Controllers
{
    public class HistoryController : Controller
    {


        private readonly IUnitOfWorkServices _UnitOfWorkServices;
        public HistoryController(IUnitOfWorkServices unitOfWorkServices)
        {
            _UnitOfWorkServices = unitOfWorkServices;
        }



      

        public IActionResult Index()
        {
            var HistoryList = _UnitOfWorkServices.HistorysServices.GetHistoryListForBusinessLogic();

            return View(HistoryList);
        }
    }
}
