

namespace systemFood.Services
{
    public class OrderService : IOrderService
    {
        private readonly IGenericRepository<Orders> _RepositoryGeneric;
        public OrderService(IGenericRepository<Orders> _repositoryGeneric)
        {
            _RepositoryGeneric = _repositoryGeneric;
        }

      

        public string NewOrder()
        {

            string orderId = $"#{Guid.NewGuid().ToString().Substring(0, 6)}";
            return orderId;
        }

        public async Task SaveOrderServr( OrderModel orderModels)
        {
            Orders orders  = new Orders();
            orders.OrderId = orderModels.OrderId;
            foreach (var ItemSession in orderModels.items)
            {

                var Selected = ItemSession.Extras.Where(x=>x.IsSelected).ToList();



                orders.Items.Add(new OrderItems
                {
                    
                    ProductId      = ItemSession.Id,
                    Note           = ItemSession.Description,
                    UnitPrice      = (decimal)(ItemSession.Quantity * ItemSession.Price),
                    Size           = ItemSession.Size,
                    Quantity       = ItemSession.Quantity,
                    DateTime       = DateTime.Now,
                    OrderId        = orderModels.OrderId,
                    selectExtra    = Selected.Select(x => new SelectExtrasProduct
                    {
                        ExtraId = x.Id,
                        Description = orderModels.Descrebtions

                    }).ToList(),
                });
                orders.TotalAmount = orders.Items.Sum(x=>x.UnitPrice);
                if ((int)ItemSession.paymentMethod==1)
                {
                    orders.PaymentMethod = "Cash";

                }
                else if((int)ItemSession.paymentMethod == 2)
                {
                    orders.PaymentMethod = "CreditCard";
                }
                else if ((int)ItemSession.paymentMethod == 3)
                {
                    orders.PaymentMethod = "VisaCard";
                }
            }
            await _RepositoryGeneric.Create(orders);
        }





    }
}
