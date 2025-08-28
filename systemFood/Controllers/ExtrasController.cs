using systemFood.UnitofWork.Interface;

namespace systemFood.Controllers
{
    public class ExtrasController : Controller
    {
        private const string CartSessionKey = "ProductIds";
        private readonly IUnitOfWorkServices _UnitOfWorkServices;
        public ExtrasController(IUnitOfWorkServices unitOfWorkServices)
        {
            _UnitOfWorkServices = unitOfWorkServices;
        }




        // Display form to create a new extra item
        public async Task<IActionResult> Create()
        {
            // Get categories from database to populate the dropdown
            var GetDataCatogry = await _UnitOfWorkServices.CategoryService.GetCategoriesForBusinessLogic();

            // Prepare view model with category list
            EditExtrasViewModel addNewExtras = new EditExtrasViewModel()
            {
                SelectCatogry = GetDataCatogry
            };

            return View(addNewExtras);
        }

        // Handle form submission for creating a new extra item
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EditExtrasViewModel addNewExtras)
        {
            // Validate the incoming model
            if (!ModelState.IsValid)
            {
                // Reload category list for the dropdown if model is invalid
                var GetDataCatogry = await _UnitOfWorkServices.CategoryService.GetCategoriesForBusinessLogic();
                addNewExtras.SelectCatogry = GetDataCatogry;

                return View(addNewExtras);
            }

            // Call service to create the extra item
            await _UnitOfWorkServices.ExtraServices.CreateAsync(addNewExtras);

            // Redirect to extras list page in settings
            return RedirectToAction("MineExtras", "Settings");
        }

        // Display form to update an existing extra item
        public async Task<IActionResult> Update(int Id)
        {
            // Get extra item data by ID and send to view
            var SendData = await _UnitOfWorkServices.ExtraServices.GetToSendDataToExtras(Id);
            return View(SendData);
        }

        // Handle form submission for updating an existing extra
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(EditExtrasViewModel addNewExtras)
        {
            // Call service to update extra item
            await _UnitOfWorkServices.ExtraServices.UpdateAsync(addNewExtras);

            // Redirect to extras list page
            return RedirectToAction("MineExtras", "Settings");
        }

        // Delete an extra item by ID
        [HttpDelete]
        public async Task<IActionResult> Delete(int Id)
        {
            // Call service to delete extra item by ID
            await _UnitOfWorkServices.ExtraServices.DeleteAsync(Id);

            // Redirect to extras list page
            return RedirectToAction("MineExtras", "Settings");
        }

        // Handle selection of extras for a specific product
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SelectExtras(SelectProductAndSelectExtra SelectProductViweModel)
        {
            // Get selected product by ID
            var selectedProduct = _UnitOfWorkServices.MineFoodServices.GetByIdProduct(SelectProductViweModel.Products.Id);

            // Get category list for product mapping
            var categoryList = await _UnitOfWorkServices.MineFoodServices.GetViewCateogry();

            // Retrieve the current order from session
            var CurrentCartOrderExtra = HttpContext.Session.GetObject<OrderModel>(CartSessionKey);

            // Map product and categories to view model
            var productViewModel = _UnitOfWorkServices.ExtraServices.MapToSelectProductForBusinessLogic(selectedProduct, categoryList);

            // Assign updated product view model back
            SelectProductViweModel.Products = productViewModel;
            if (CurrentCartOrderExtra == null || CurrentCartOrderExtra.items == null)
                return RedirectToAction("Index", "Home");
           

            // Update selected extras and pricing in the cart
            foreach (var OrderExtra in CurrentCartOrderExtra.items)
            {
                if (SelectProductViweModel.Products.Id == OrderExtra.Id)
                {
                    // Set selected extras
                    OrderExtra.Extras = SelectProductViweModel.Extras;

                    // Calculate total price of selected extras
                    var selectedExtrasTotal = OrderExtra.Extras
                        .Where(extra => extra.IsSelected)
                        .Sum(extra => extra.Price);

                    // Update totals in the order
                    CurrentCartOrderExtra.TotalAmountExtra += (double)selectedExtrasTotal;
                    CurrentCartOrderExtra.TotalAmount += (double)selectedExtrasTotal;

                    // Update descriptions if provided
                    CurrentCartOrderExtra.Descrebtions = SelectProductViweModel.Descrebtions;
                }
            }

            // Save updated order back into the session
            HttpContext.Session.SetObject(CartSessionKey, CurrentCartOrderExtra);

            // Redirect back to the home page
            return RedirectToAction("index", "Home");
        }
    }
}
