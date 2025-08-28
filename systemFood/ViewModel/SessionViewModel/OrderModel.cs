using systemFood.ViewModel.Product;

namespace systemFood.ViewModel.SessionViewModel
{
    public class OrderModel
    {
        public string OrderId {  get; set; }
        public List<SelectProduct> items { get; set; } = new();
        public double TotalAmountExtra {  get; set; }
        public double TotalAmount {  get; set; }
        public string Descrebtions { get; set; } = string.Empty;
    }
}
