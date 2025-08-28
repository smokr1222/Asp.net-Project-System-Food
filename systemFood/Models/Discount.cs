namespace systemFood.Models
{
    public class Discount
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Discount")]
        public string DescaondName { get; set; }=string.Empty;
        [Display(Name = "Discount Number")]
        public double DescaondNumber { get; set;}
    }
}
