using systemFood.Models.MultiModel;

namespace systemFood.Repository.Interface
{
    public interface IProductRepository
    {

        Product GetProductById(int id);
        IEnumerable<Product> GetAllProductData();
        ProductAndCatogry GetProductAndCategoryData();
    }
}
