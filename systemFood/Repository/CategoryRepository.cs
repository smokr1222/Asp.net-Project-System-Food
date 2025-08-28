
namespace systemFood.Repository
{
    public class CategoryRepository : ICategoryRepository
    {


        private readonly AppDbContext _db;
        public CategoryRepository(AppDbContext db)
        {
            _db = db;
        }

        public Task<List<Category>> GetAllCategoriesWithRelatedData()
        {
            var DataAllForCategoris = _db.Category.Include(Product => Product.IProduct).Include(Extra => Extra.IExtras).ToListAsync();

            return DataAllForCategoris;

        }


        public Task<Category> GetCategoryByIdWithIProductAsync(int id)
        {
            var GetDataByIdForCategoris = _db.Category.Include(Product => Product.IProduct).FirstOrDefaultAsync(x => x.Id == id);
          
            return  GetDataByIdForCategoris;
        }



    }
}
