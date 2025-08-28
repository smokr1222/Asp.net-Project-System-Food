

using System.Threading.Tasks;
using systemFood.Models.MultiModel;

namespace systemFood.Servrses
{

    public class MineFoodService : IMineFoodServices
    {
        private readonly IGenericRepository<Product> _RebostryGeneric;

        private readonly ICategoryRepository _RepositoryCategory;
        private readonly IProductRepository _RebostryProduct;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly string _imgPathFolders;
        private readonly string _imgPathFoldersDeffult;
        public MineFoodService(IWebHostEnvironment webHostEnvironment,IProductRepository rebostryProduct, ICategoryRepository repositoryCategory, IGenericRepository<Product> rebostryGeneric)
        {
            _webHostEnvironment = webHostEnvironment;
            _imgPathFolders = $"{_webHostEnvironment.WebRootPath}{Settingss._ImgeFolderToServer}";
            _imgPathFoldersDeffult = $"{_webHostEnvironment.WebRootPath}{Settingss._ImgeFolderToServerDefullt}";
            _RebostryProduct = rebostryProduct;
            _RepositoryCategory = repositoryCategory;
            _RebostryGeneric = rebostryGeneric;
        }
        public ProductAndCatogry GetProductAndCatogry()
        {

            return _RebostryProduct.GetProductAndCategoryData();
        }


        public async Task<List<Category>> GetViewCateogry()
        {

            return await _RepositoryCategory.GetAllCategoriesWithRelatedData();
        }

        public async Task<string> CoverSaveToServer(IFormFile Covers)
        {
            string CoverName = "";
            if (Covers != null)
            {
                CoverName = $"{Guid.NewGuid()}{Covers.FileName}";
                var Paths = Path.Combine(_imgPathFolders, CoverName);

                using var strem = File.Create(Paths);
                await Covers.CopyToAsync(strem);

            }
            else
            {
                CoverName = $"images(3).jpeg";

                var Paths = Path.Combine(_imgPathFoldersDeffult, CoverName);

                //using var strem = File.Create(Paths);
                //await Covers.CopyToAsync(strem);
            }
            return CoverName;
        }



        public Product GetByIdProduct(int id)
        {
            var FindProduct = _RebostryProduct.GetProductById(id);
            return FindProduct;

        }





        public async Task<bool> SelectProductListForBusinessLogic(OrderModel orderModel, int id)
        {
            var Product = await _RebostryGeneric.GetById(id);

            SelectProduct? Existing = orderModel.items.FirstOrDefault(x => x.Id == id);
            if (Existing != null)
            {
                if (Product.Stock > Existing.Quantity)
                {
                    Existing.Quantity++;

                }

            }
            else
            {

                if (Product.Stock != 0)
                {
                    orderModel.items.Add(new SelectProduct
                    {
                        Id = Product.Id,
                        Name = Product.Name,
                        Description = Product.Description,
                        Price = Product.Price,
                        Cover = Product.Cover,
                        Size = Product.Size,
                        Stock = (int)Product.Stock,
                    });
                }
            }
            Existing = orderModel.items.FirstOrDefault(x => x.Id == id);

            if (Existing != null)
            {
                if (Existing.Stock <= 0)
                {
                    return false;
                    //TempData["error"] = "لا يمكنك الكمية قليلة";
                }
                else
                {

                    foreach (var Stocks in orderModel.items)
                    {
                        if (Stocks.Id == id)
                        {
                            Stocks.Stock = (int)Stocks.Stock - 1;

                        }
                    }
                    var TotalSelectProduct = orderModel.items.Sum(x => x.Price * x.Quantity);
                    orderModel.TotalAmount = TotalSelectProduct;
                    return true;
                }
            }
            return false;
        }







        public bool DecreaseQuantityForBusinessLogic(OrderModel SessionProduct, int Id)
        {

            var Existing = SessionProduct.items.FirstOrDefault(y => y.Id == Id);

            if (Existing != null)
            {
                Existing.Quantity--;
                SessionProduct.TotalAmount -= Existing.Quantity * Existing.Price;
                if (Existing.Quantity <= 0)
                    SessionProduct.items.Remove(Existing);
                return true;
            }
            return false;

        }

        public bool IncreaseQuantityForBusinessLogic(OrderModel SessionProduct, int Id)
        {

            var Existing = SessionProduct.items.FirstOrDefault(y => y.Id == Id);

            if (Existing.Quantity == Existing.Stock+1)
            {
                return false;
            }
            else
            {
                Existing.Quantity++;
                SessionProduct.TotalAmount+=Existing.Quantity*Existing.Price;
                return true;

            }
        }








    }
}
