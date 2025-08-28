namespace systemFood.ViewModel.Extras
{
    public class AddNewExtrasViewModel
    {
        public int Id                        { get; set; }
        public string TitleExtra             { get; set; }
        public double Prise                  { get; set; }
        public List< Category> SelectCatogry { get; set; }
        public int CatogryID                 { get; set; }


    }
}
