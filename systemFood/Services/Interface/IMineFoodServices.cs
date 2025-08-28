
namespace systemFood.Servrses.Interfase
{
    public interface IMineFoodServices
    {



        Product GetByIdProduct(int id);




        Task<List<Category>> GetViewCateogry();

        Task<string> CoverSaveToServer(IFormFile Covers);

        Task<bool> SelectProductListForBusinessLogic(OrderModel orderModel, int id);
         bool DecreaseQuantityForBusinessLogic(OrderModel orderModel, int id);
         bool IncreaseQuantityForBusinessLogic(OrderModel SessionProduct, int Id);

    }
}
