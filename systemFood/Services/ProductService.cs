


namespace systemFood.Servrses
{
    public class ProductService:IProductService
    {

        private readonly IGenericRepository<Product> _RepositoryProduct;
        private readonly IGenericRepository<Orders>  _RepositoryOrders;
        private readonly IProductRepository          _RebostryProducts;
        private readonly IMineFoodServices           _mineFoodServices;
        private readonly ICategoryService            _categoryService;
        private readonly IWebHostEnvironment         _webHostEnvironment;
        private readonly string                      _imgPathFolders;
        public ProductService(IGenericRepository<Product> RepositoryProduct, ICategoryService categoryService, IMineFoodServices mineFoodServices, IWebHostEnvironment webHostEnvironment, IGenericRepository<Orders> repositoryOrders, IProductRepository rebostryProducts)
        {
            _RepositoryProduct  = RepositoryProduct;
            _categoryService    = categoryService;
            _mineFoodServices   = mineFoodServices;
            _webHostEnvironment = webHostEnvironment;
            _imgPathFolders     = $"{_webHostEnvironment.WebRootPath}{Settingss._ImgeFolderToServer}";
            _RepositoryOrders   = repositoryOrders;
            _RebostryProducts   = rebostryProducts;
        }
        private const string CartSessionKey = "ProductIds";


       
        public async Task CreateAsync(AddNewProductViewModel product)
        {
            string CoverName;
            if (product.Cover!=null)
            {
                 CoverName = await _mineFoodServices.CoverSaveToServer(product.Cover);

            }
            else
            {
                 CoverName = await _mineFoodServices.CoverSaveToServer(product.Cover);

            }
            Product Item  = new()
            {
                Name           = product.Name,
                Description    = product.Description,
                Price          = product.Prise,
                CategoryId      = product.CatogryId,
                Calories       = product.Calories,
                IsTakeaway     = product.IsTakeaway,
                CompletionTime = product.CompletionTime,
                Size           = product.Size,
                Stock          = product.Stock,
                Cover          = CoverName,
            };
            if (Item is not null)
               await _RepositoryProduct.Create(Item);
           
        }

        public async Task DeleteAsync(int id)
        {
            var Find = await _RepositoryProduct.GetById(id);
            if (Find != null)
            {
                var Affect = await _RepositoryProduct.Delete(Find);
                if (Affect > 0)
                {
                    var paths = Path.Combine(_imgPathFolders, Find.Cover);
                    File.Delete(paths);
                }
            }
        }

        public async Task<EditProductViewModel> EditProductView(int id)
        {
            var Find = await _RepositoryProduct.GetById(id);
            EditProductViewModel Edit = new()
            {
                id             = id,
                Name           = Find.Name,
                Description    = Find.Description,
                Prise          = Find.Price,
                Size           = Find.Size,
                CompletionTime = Find.CompletionTime,
                Catogry        = _categoryService.GetCategorySelectList(),
                CatogryId      = Find.CategoryId,
                Calories       = Find.Calories,
                IsTakeaway     = Find.IsTakeaway,
                Stock          = Find.Stock,
            };
            return Edit;
        }

        public async Task UpdateAsync(EditProductViewModel Edit)
        {
            var Find         = await _RepositoryProduct.GetById(Edit.id);
            var OldCover     = Find.Cover;
            bool HasNewCover = Edit.Cover is not null;
            if (HasNewCover)
                Find.Cover = await _mineFoodServices.CoverSaveToServer(Edit.Cover!);
            
            Find.Name           = Edit.Name;
            Find.Description    = Edit.Description;
            Find.Price          = Edit.Prise;
            Find.Size           = Edit.Size;
            Find.CompletionTime = Edit.CompletionTime;
            Find.CategoryId      = Edit.CatogryId;
            Find.Calories       = Edit.Calories;
            Find.IsTakeaway     = Edit.IsTakeaway;
            Find.Stock          = Edit.Stock;
            var affect = await _RepositoryProduct.Update(Find);
            if (affect > 0)
            {
                if (HasNewCover)
                {
                    var paths = Path.Combine(_imgPathFolders, OldCover);
                    File.Delete(paths);
                }
            }
            else
            {
                var paths = Path.Combine(_imgPathFolders, Edit.Cover!.FileName);
                File.Delete(paths);
            }
        }

        public async Task UpdateProductStock(OrderModel Edit)
        {
            Product product = new Product();
            foreach (var item in Edit.items)
            {
                product = await _RepositoryProduct.GetById(item.Id);
                if (product.Stock == item.Quantity)
                {
                    product.Stock = (int)item.Stock;
                }
                else if (product.Stock != item.Quantity)
                {
                    if (item.Quantity<= product.Stock)
                    {
                        product.Stock = (int)item.Stock;
                    }
                }
            }
            var affect = await _RepositoryProduct.Update(product);
        }

       


        public IEnumerable<Product> GetProductAllService()
        {
            return  _RebostryProducts.GetAllProductData();

        }



    }
}
