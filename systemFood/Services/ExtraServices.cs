
namespace systemFood.Services
{
    public class ExtraServices : IExtraServices
    {
        public readonly IExtraRepostory             _extraRepostory;
        private readonly IGenericRepository<Extras> _RepositoryGeneric;
        private readonly ICategoryService           _CategoryService;

        public ExtraServices(IExtraRepostory extraRepostory, IGenericRepository<Extras> repositoryGeneric, ICategoryService categoryService)
        {
            _extraRepostory    = extraRepostory;
            _RepositoryGeneric = repositoryGeneric;
            _CategoryService   = categoryService;
        }

        public List<SelectExtra> MapToSelectExtra()
        {
            return _extraRepostory.MapToSelectExtra();
        }

        public SelectProduct MapToSelectProductForBusinessLogic(Product product, List<Category> LastOneCatogry)
        {
            return new SelectProduct
            {

                Id          = product.Id,
                Name        = product.Name,
                Description = product.Description,
                CatogryID   = product.CategoryId,
                Price       = product.Price,
                Size        = product.Size,
                Stock       = product.Stock,
                Cover       = product.Cover,
                Categories  = LastOneCatogry.Where(x => x.Id == product.CategoryId).ToList(),

            };
        }



        public async Task<EditExtrasViewModel> GetToSendDataToExtras(int Id)
        {
            var FindToExtras               = await FindToExtraById(Id);
            var GetDataFromDBCatogry       = await _CategoryService.GetCategoriesForBusinessLogic();
            EditExtrasViewModel EditExtras = new EditExtrasViewModel()
            {
                TitleExtra    = FindToExtras.Name,
                Prise         = (double)FindToExtras.Price,
                CatogryID     = FindToExtras.CatogryId,
                SelectCatogry = GetDataFromDBCatogry.Where(x => x.Id == FindToExtras.CatogryId).ToList(),
            };
            return EditExtras;
        }




        public async Task CreateAsync(AddNewExtrasViewModel Extras)
        {
            Extras Item = new()
            {
                Name      = Extras.TitleExtra,
                Price     = (decimal)Extras.Prise,
                CatogryId = Extras.CatogryID,
                
            };
            if (Item is not null)
                await _RepositoryGeneric.Create(Item);
           
        }



        public async Task UpdateAsync(EditExtrasViewModel Extras)
        {
            var FindToExtra       = await FindToExtraById(Extras.Id);
            FindToExtra.Name      = Extras.TitleExtra;
            FindToExtra.Price     = (decimal) Extras.Prise;
            FindToExtra.CatogryId = Extras.CatogryID;

            if (FindToExtra is not null)
                await _RepositoryGeneric.Update(FindToExtra);
            

        }


        public   IEnumerable<Extras> GetAllToExtra()
        {
            return  _RepositoryGeneric.GetAllDataGenarec();
        }

        public async Task<Extras> FindToExtraById(int id)
        {

            var FindToExtras = await _RepositoryGeneric.GetById(id);
            return FindToExtras;

        }

        public async Task<int> DeleteAsync(int Id)
        {
            var FindToExtra = await FindToExtraById(Id);


            if (FindToExtra != null)
            {
                  return await _RepositoryGeneric.Delete(FindToExtra);
            
            }
            else
            {
                return  0;

            }




        }
    }
}
