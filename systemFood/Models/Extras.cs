
using System.ComponentModel.DataAnnotations.Schema;

namespace systemFood.Models
{

    public class Extras
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }=string.Empty;
        public decimal Price { get; set; }
        public bool IsSelected {  get; set; }
        [ForeignKey("category")]
        public int CatogryId {  get; set; }
        public Category? category { get; set; }


    }
}
