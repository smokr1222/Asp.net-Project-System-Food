namespace systemFood.UnitofWork.Interface
{
    public interface IUnitOfWorkServices
    {
        IProductService ProductService { get; }
        IMineFoodServices MineFoodServices { get; }
        IOrderService OrderService { get; }
        ICategoryService CategoryService { get; }
        IDescaondService DescaondService { get; }
        IExtraServices ExtraServices { get; }
        IHistorysServices HistorysServices { get; }
        IOrderItemSevice OrderItemSevice { get; }
        IGenericRepository<Product> ProductRepository { get; }
        Task<int> CompleteAsync();


    }
}
