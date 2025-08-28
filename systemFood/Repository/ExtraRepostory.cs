


namespace systemFood.Repository
{
    public class ExtraRepostory : IExtraRepostory
    {
        public readonly AppDbContext _db;
        public ExtraRepostory(AppDbContext db)
        {
            _db = db;
        }
        public List<SelectExtra> MapToSelectExtra()
        {

            return _db.Extras.Select(Extra => new SelectExtra
            {
                Id = Extra.Id,
                Name = Extra.Name,
                CatogryID = Extra.CatogryId,
                IsSelected = Extra.IsSelected,
                Price = Extra.Price,

            }).ToList();
            


        }
    }
}
