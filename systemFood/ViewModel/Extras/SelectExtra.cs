namespace systemFood.ViewModel.Extras
{
    public class SelectExtra
    {
        public int Id          { get; set; }
        public int CatogryID   { get; set; }
        public string Name     { get; set; } = string.Empty;
        public decimal Price   { get; set; }
        public bool IsSelected { get; set; }

    }
}
