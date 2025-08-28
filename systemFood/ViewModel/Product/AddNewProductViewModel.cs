using Microsoft.AspNetCore.Mvc.Rendering;

namespace systemFood.ViewModel.Product
{
    public class AddNewProductViewModel
    {


        public string Name         { get; set; } = string.Empty;
        [StringLength(512)]
        [DataType(DataType.MultilineText)]
        public string? Description { get; set; } = string.Empty;
        [Required]
        public string Size         { get; set; } = string.Empty;
        [Required]
        [Range(0.1, 999999)]
        public double Prise        { get; set; }
        public IFormFile? Cover    { get; set; } 
        public int CatogryId       { get; set; } 
        [Required]
        public IEnumerable<SelectListItem> Catogry { get; set; } = Enumerable.Empty<SelectListItem>();
        [Range(1, 9999999)]
        public double    Calories { get; set; }

        public bool  IsTakeaway     { get; set; }
        [Range(1, 10000)]
        public int   CompletionTime { get; set; } 
        public int Stock { get; set; }  


    }
}
