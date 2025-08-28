using Microsoft.EntityFrameworkCore;
using systemFood.UnitofWork.Interface;

namespace systemFood.UnitofWork
{
    public class UnitOfWorkServices:IUnitOfWorkServices
    {

        private readonly AppDbContext _context;

        public IProductService ProductService { get; }
        public IMineFoodServices MineFoodServices { get; }
        public IOrderService OrderService { get; }
        public ICategoryService CategoryService { get; }
        public IDescaondService DescaondService { get; }
        public IExtraServices ExtraServices { get; }
        public IHistorysServices HistorysServices { get; }
        public IOrderItemSevice OrderItemSevice { get; }
        public IGenericRepository<Product> ProductRepository { get; }

        public UnitOfWorkServices(
             AppDbContext context,
             IProductService productService,
             IMineFoodServices mineFoodServices,
             IOrderService orderService,
             ICategoryService categoryService,
             IDescaondService descaondService,
             IExtraServices extraServices,
             IHistorysServices historysServices,
             IOrderItemSevice orderItemSevice,
             IGenericRepository<Product> productRepository
         )
        {
            _context = context;

            ProductService = productService;
            MineFoodServices = mineFoodServices;
            OrderService = orderService;
            CategoryService = categoryService;
            DescaondService = descaondService;
            ExtraServices = extraServices;
            HistorysServices = historysServices;
            OrderItemSevice = orderItemSevice;
            ProductRepository = productRepository;
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

    }
}
