using System.ComponentModel.DataAnnotations.Schema;

namespace systemFood.Models
{
    public class SelectExtrasProduct
    {
        [Key]
        public int Id { get; set; }
        public OrderItems orderitems { get; set; }
        public int orderitemid { get; set; }

        [ForeignKey("ExtraId")]
        public Extras Extras { get; set; }
        public int ExtraId { get; set; }
        public string? Description {  get; set; }=string.Empty;




    }
}
