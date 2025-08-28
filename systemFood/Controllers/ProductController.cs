namespace systemFood.Controllers
{
    public class ProductController : Controller
    {
        private readonly IUnitOfWorkServices _UnitOfWorkServices;
        public ProductController(IUnitOfWorkServices unitOfWorkServices)
        {
            _UnitOfWorkServices = unitOfWorkServices;
        }

        private const string CartSessionKey = "ProductIds";
        [HttpGet]
        public IActionResult Create()
        {
            AddNewProductViewModel models = new()
            {
                Catogry = _UnitOfWorkServices.CategoryService.GetCategorySelectList()
            };
            return View(models);
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddNewProductViewModel models)
        {
            if (!ModelState.IsValid)
                models.Catogry = _UnitOfWorkServices.CategoryService.GetCategorySelectList();
            
            await _UnitOfWorkServices.ProductService.CreateAsync(models);
            return RedirectToAction("MineProduct", "Settings");
        }





        [HttpGet]
        public async Task< IActionResult> Update(int id)
        {
            var Edit = await _UnitOfWorkServices.ProductService.EditProductView(id);
            return View(Edit);
        }

        [HttpPost]
        public async Task<IActionResult> Update(EditProductViewModel models)
        {
            if (!ModelState.IsValid)
            {
                models.Catogry = _UnitOfWorkServices.CategoryService.GetCategorySelectList();
            }
            await _UnitOfWorkServices.ProductService.UpdateAsync(models);
            return RedirectToAction("MineProduct", "Settings");
        }




        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _UnitOfWorkServices.ProductService.DeleteAsync(id);
            TempData["SuccessMessage"] = "تم حذف العنصر بنجاح";
            return Ok();

        }





        public IActionResult ViewPartialProduct()
        {

            return View();

        }







        public async Task<IActionResult> DetalsProduct(int id , SelectProductAndSelectExtra productAndSelectExtra)
        {
            var Product                  =  _UnitOfWorkServices.MineFoodServices.GetByIdProduct(id);
            var CategoryList             = await _UnitOfWorkServices.MineFoodServices.GetViewCateogry();
            var CurrentCartOrderExtra    = HttpContext.Session.GetObject<OrderModel>(CartSessionKey);
            var SelectedProductViewModel = _UnitOfWorkServices.ExtraServices.MapToSelectProductForBusinessLogic(Product, CategoryList);
            var ExtraItemsFromDatabase   = _UnitOfWorkServices.ExtraServices.MapToSelectExtra();
            var ProductCategories        = CategoryList.Where(x => x.Id == Product.CategoryId).ToList();
            var TotalOrderPrice          = CurrentCartOrderExtra.items.Sum(x => x.TotalPrisenew);



            productAndSelectExtra.Products   = SelectedProductViewModel;
            productAndSelectExtra.Extras     = ExtraItemsFromDatabase;
            productAndSelectExtra.categories = ProductCategories;
            productAndSelectExtra.Total      = TotalOrderPrice;
       


            return View(productAndSelectExtra);

        }












    }
}

