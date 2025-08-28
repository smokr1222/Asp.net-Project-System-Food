
namespace systemFood.Services
{
    public class OrderItemSevice : IOrderItemSevice
    {

        private readonly IOrderItemRepository _RepositoryOrdersItem;
        public OrderItemSevice(IOrderItemRepository repositoryOrdersItem)
        {
            _RepositoryOrdersItem = repositoryOrdersItem;
        }

        public List<Orders> GetOrderItemList()
        {
            return _RepositoryOrdersItem.GetOrderItemListIncluds();

        }
    }
}
