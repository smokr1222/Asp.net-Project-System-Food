
namespace systemFood.Models
{
    public class Category
    {
        [Key]
        public int Id {  get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
        public ICollection<Product>? IProduct { get; set; }
        public ICollection<Extras>? IExtras { get; set; }

    }
}
