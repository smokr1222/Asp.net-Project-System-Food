




namespace systemFood.Servrses
{
    public class CategoryService : ICategoryService
    {
        private readonly IGenericRepository<Category> _RepositoryGeneric;
        private readonly ICategoryRepository          _RepositoryCategory;
        public CategoryService(ICategoryRepository repositoryCategory, IGenericRepository<Category> repositoryGeneric)
        {
            _RepositoryCategory = repositoryCategory;
            _RepositoryGeneric  = repositoryGeneric;
        }
        public IEnumerable<SelectListItem> GetCategorySelectList()
        {
            var Catogry = _RepositoryGeneric.GetAllDataGenarec();

            return Catogry.Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() }).OrderBy(x => x.Text).ToList();
        }


       
        public async Task CreateAsync(AddNewCategoryViewModel categoryViewModel)
        {
            Category categoryModel = new()
            {
                Id    = categoryViewModel.Id,
                Name  = categoryViewModel.Name,
                Icon = categoryViewModel.Icon,
            };
           await _RepositoryGeneric.Create(categoryModel);
        }




        public async Task DeleteAsync(int id)
        {
            var Find = await _RepositoryGeneric.GetById(id);
            if (Find != null)
               await _RepositoryGeneric.Delete(Find);
        }
        public async Task<List<Category>> GetCategoriesForBusinessLogic()
        {
            var categry= await _RepositoryCategory.GetAllCategoriesWithRelatedData();
            return categry;
        }
        public async Task<Category> GetCategoryByIdWithIProductBusinessLogic(int id)
        {
            var categry = await _RepositoryCategory.GetCategoryByIdWithIProductAsync(id);
            return categry;
        }




    }
}
