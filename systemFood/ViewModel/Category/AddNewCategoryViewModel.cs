namespace systemFood.ViewModel.Catogry
{
    public class AddNewCategoryViewModel
    {

        [Key]
        public int Id      { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;

    }
}
