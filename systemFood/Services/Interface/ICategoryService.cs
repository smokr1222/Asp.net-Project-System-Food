
using systemFood.ViewModel.Catogry;

namespace systemFood.Servrses.Interfase
{
    public interface ICategoryService 
    {
        IEnumerable<SelectListItem> GetCategorySelectList();

        Task CreateAsync(AddNewCategoryViewModel categoryViewModel);
        Task DeleteAsync(int id);


        Task<List<Category>> GetCategoriesForBusinessLogic();
        Task<Category> GetCategoryByIdWithIProductBusinessLogic(int id);


    }
}
