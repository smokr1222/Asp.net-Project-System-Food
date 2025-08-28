
using Microsoft.EntityFrameworkCore.Migrations;

namespace systemFood.Services
{
    public class HistorysServices : IHistorysServices
    {

        private readonly IHistorysRepositoy _Histryrepository;

        public HistorysServices(IHistorysRepositoy histryrepository)
        {
            _Histryrepository = histryrepository;
        }

        public IEnumerable<Orders> GetHistoryListForBusinessLogic()
        {
            var historyList = _Histryrepository.GetHistory();
            return historyList;
        }
    }
}
