namespace systemFood.Models
{
    public class OrderItemExtrasViewModel
    {
        public int OrderItemId     { get; set; }
        public string ProductName  { get; set; }
        public List<Extras> Extras { get; set; }
    }
}
