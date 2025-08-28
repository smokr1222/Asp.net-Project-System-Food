
using systemFood.ViewModel.Product;
using systemFood.ViewModel.SessionViewModel;

namespace systemFood.Servrses.Interfase
{
    public interface IProductService
    {



        Task CreateAsync(AddNewProductViewModel products);
        Task UpdateAsync(EditProductViewModel Edit);
        Task DeleteAsync(int id);
        Task< EditProductViewModel> EditProductView(int id);

        Task UpdateProductStock(OrderModel Edit);

        IEnumerable<Product> GetProductAllService();



    }
}
