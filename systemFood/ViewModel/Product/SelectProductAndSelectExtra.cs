using System.Text.Json.Serialization;
using systemFood.ViewModel.Extras;

namespace systemFood.ViewModel.Product
{
    public class SelectProductAndSelectExtra
    {

        public SelectProduct Products { get; set; }

        public List<SelectExtra> Extras { get; set; } = new();

        public List<Category> categories { get; set; } = new();

        public string Descrebtions { get; set; } = string.Empty;

        public string Size { get; set; } = string.Empty;

        public double? Total { get; set; }



    }
}
