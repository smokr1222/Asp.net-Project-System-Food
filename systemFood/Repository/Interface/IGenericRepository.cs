

namespace systemFood.Rebostry.InterFase
{
    public interface IGenericRepository<T>where T : class
    {



        Task<T> GetById(int id);

        IEnumerable<T> GetAllDataGenarec();

       Task Create(T item);
       Task<int> Update(T item);
       Task<int> Delete(T item);




    }
}
