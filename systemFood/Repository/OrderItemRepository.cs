

namespace systemFood.Repository
{
    public class OrderItemRepository : IOrderItemRepository
    {
        private readonly AppDbContext _db;
        public OrderItemRepository(AppDbContext db)
        {
            _db = db;
        }

        public List<Orders> GetOrderItemListIncluds()
        {

            var DataAllForOrder = _db.Orders
           .Include(o => o.Items).ThenInclude(x=>x.Product)
           .ToList();
            return DataAllForOrder;  

        }
    }
}
