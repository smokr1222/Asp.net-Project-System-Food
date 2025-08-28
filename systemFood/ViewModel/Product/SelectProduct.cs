using systemFood.ViewModel.Extras;

namespace systemFood.ViewModel.Product
{
    public class SelectProduct
    {
        public int Id { get; set; }

        public int CatogryID { get; set; }
        [Required]
        [StringLength(90)]
        [DataType(DataType.Text)]
        public string Name { get; set; } = string.Empty;
        [StringLength(512)]
        [DataType(DataType.MultilineText)]
        public string ?Description { get; set; } = string.Empty;
        [Required]
        public string Size { get; set; } = string.Empty;
        [Required]
        [Range(0.1, 9999)]
        public double Price { get; set; }
        public string? Cover { get; set; } = string.Empty;
        public int Quantity { get; set; } = 1;
        public int Stock { get; set; } 
        public decimal TotalPrise {  get; set; }
        public double TotalPrisenew =>  Price * Quantity;
        public List< Category> ?Categories { get; set; }
        public List<SelectExtra> Extras { get; set; } = new();
        public ePaymentMethod paymentMethod { get; set; }
        public enum  ePaymentMethod { eMoneyCach=1, eCreditCard=2, VisaCard=3 };



    }
}
