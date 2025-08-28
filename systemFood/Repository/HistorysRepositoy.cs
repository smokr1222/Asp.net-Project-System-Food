
using System.Threading.Tasks;

namespace systemFood.Repository
{
    public class HistorysRepositoy : IHistorysRepositoy
    {
        public AppDbContext _db;
        public HistorysRepositoy(AppDbContext db)
        {
            _db = db;
        }

        public  IEnumerable< Orders> GetHistory()
        {
            var ListOrder=  _db.Orders.ToList();
            return ListOrder;
        }
    }
}
