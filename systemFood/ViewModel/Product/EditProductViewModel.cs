namespace systemFood.ViewModel.Product
{
    public class EditProductViewModel: AddNewProductViewModel
    {
        public int id {  get; set; }

        public IFormFile? Cover { get; set; } = default!;

        public string CurentCover {  get; set; }=string.Empty;

    }
}
