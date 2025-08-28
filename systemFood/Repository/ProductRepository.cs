
using systemFood.Models.MultiModel;

namespace systemFood.Repository
{
    public class ProductRepository:IProductRepository
    {

        private readonly AppDbContext _db;
        public ProductRepository(AppDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Product> GetAllProductData()
        {

            var DataAllForProduct = _db.Products.Include(c => c.Category).ThenInclude(x => x.IExtras).Include(x => x.OrdersLines).ToList();
            return DataAllForProduct;

        }


        public Product GetProductById(int Id)
        {

            var product = _db.Products
               .Include(p => p.Category)
                   .ThenInclude(c => c.IExtras)
               .Include(p => p.OrdersLines)
               .FirstOrDefault(p => p.Id == Id);

            if (product == null)
                throw new Exception($"Product with ID {Id} not found.");
            

            return product;

        }



        public ProductAndCatogry GetProductAndCategoryData()
        {
            ProductAndCatogry cat = new()
            {
                Product = _db.Products.ToList(),
                Category = _db.Category.ToList(),
                Extras=_db.Extras.ToList(),

            };
            return cat;
        }

    }
}
