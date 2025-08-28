

namespace systemFood.Models
{
    public class Product
    {
        [Key]
        public int Id {  get; set; }
        [Required]
        [StringLength(90)]
        [DataType(DataType.Text)]
        public string Name { get; set; }=string.Empty;
        [StringLength(512)]
        [DataType(DataType.MultilineText)]
        public string? Description { get; set; } = string.Empty;
        public string? Size { get; set; } = string.Empty;
        [Required]
        [Range(0.1,9999999)]
        public double Price { get; set; }
        public string? Cover {  get; set; } = string.Empty;
        [Required]
        public int CategoryId {  get; set; }
        public Category Category { get; set; } = default!;

        public int Stock {  get; set; } = default!;

        [Range(1, 100)]
        public int CompletionTime { get; set; } // وقت الانتهاء

        [Range(1, 9999999)]
        public double Calories { get; set; } // السعرات الحرارية

        public bool IsTakeaway { get; set; } // هل الطلب للتوصيل إلى المنزل
        public ICollection<OrderItems> OrdersLines { get; set; } = new List<OrderItems>();





    }
}
