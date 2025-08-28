namespace systemFood.Repository.Interface
{
    public interface ICategoryRepository
    {


        Task<List<Category>> GetAllCategoriesWithRelatedData();

         Task<Category> GetCategoryByIdWithIProductAsync(int id);



    }
}
