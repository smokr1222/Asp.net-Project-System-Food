using systemFood.UnitofWork.Interface;

namespace systemFood.Controllers
{
    public class CategoryController : Controller
    {



        private readonly IUnitOfWorkServices _UnitOfWorkServices;
        public CategoryController(IUnitOfWorkServices unitOfWorkServices)
        {
            _UnitOfWorkServices = unitOfWorkServices;
        }


      
        // Constructor with dependency injection for the category service
      

        // Display the form to create a new category
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // Handle form submission to create a new category
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AddNewCategoryViewModel categoryViewModel)
        {
            // Check if the submitted form data is valid
            if (!ModelState.IsValid)
                return View(categoryViewModel);
            

            // Call service to add the new category
            await _UnitOfWorkServices.CategoryService.CreateAsync(categoryViewModel);

            // Redirect to the product list/settings page after successful creation
            return RedirectToAction("MineProduct", "Settings");
        }

        // Handle deletion of a category (via DELETE request)
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            // Call service to delete the category by ID
            await _UnitOfWorkServices.CategoryService.DeleteAsync(id);

            // Set a success message to be shown via TempData (used in alerts)
            TempData["SuccessMessage"] = "Category deleted successfully.";

            // Return 200 OK response
            return Ok();
        }
    }
}
