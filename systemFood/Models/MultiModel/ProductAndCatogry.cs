using systemFood.ViewModel.Product;

namespace systemFood.Models.MultiModel
{
    public class ProductAndCatogry
    {

        public List <Product> Product {get; set;}=new List<Product>();
        public List<Category> Category { get; set; } = new List<Category>();
        public List<Extras> Extras { get; set; } = new List<Extras>();
        public IEnumerable<SelectProduct>? SelectProduct {get; set;}



    }
}
