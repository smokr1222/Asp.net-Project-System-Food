

namespace systemFood.Rebostry
{
    public class GenericRepository<T>:IGenericRepository<T> where T : class
    {



        private readonly AppDbContext _db;
        public GenericRepository(AppDbContext db)
        {
            _db = db;
        }

     
        public IEnumerable<T> GetAllDataGenarec()
        {

            var AllDataList = _db.Set<T>().ToList();
            return AllDataList;

        }

        public async Task<T> GetById (int id)
        {
            return await _db.Set<T>().FindAsync(id);

        }

      
       

        public async Task Create(T item)
        {
            _db.Set<T>().Add(item);
            await _db.SaveChangesAsync(); // يجب أن تنتظر (await) نتيجة الحفظ غير المتزامن
        }


        public async Task<int> Update(T item)
        {
            _db.Set<T>().Update(item);
           return await _db.SaveChangesAsync(); // يجب أن تنتظر (await) نتيجة الحفظ غير المتزامن

        }

       
        public async Task<int> Delete(T item)
        {
           
            _db.Remove(item);
            return await _db.SaveChangesAsync();
        }


     

    }
}
