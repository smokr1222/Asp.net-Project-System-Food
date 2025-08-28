

namespace systemFood.Services
{
    public class DescaondService : IDescaondService
    {
        private readonly IGenericRepository<Discount> _RepositoryDescaond;
        public DescaondService(IGenericRepository<Discount> repositoryDescaond)
        {
            _RepositoryDescaond = repositoryDescaond;
        }
        public decimal GetDescaondOpertionForBusinessLogic(string Descaond,decimal TotalAmount)
        {
            var listDescaond= _RepositoryDescaond.GetAllDataGenarec();
            decimal Result = 0;
            foreach (var item in listDescaond)
            {
                if (Descaond == item.DescaondName)
                     Result = TotalAmount * (1-(decimal) item.DescaondNumber);
                
            }
            return Result;
        }
    }
}
