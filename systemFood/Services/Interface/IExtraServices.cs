using systemFood.ViewModel.Extras;
using systemFood.ViewModel.Product;

namespace systemFood.Services.Interface
{
    public interface IExtraServices
    {
        IEnumerable<Extras> GetAllToExtra();
        Task<Extras> FindToExtraById(int id);
        Task<EditExtrasViewModel> GetToSendDataToExtras(int Id);

        Task CreateAsync(AddNewExtrasViewModel Extras);
        Task UpdateAsync(EditExtrasViewModel Extras);
        Task<int> DeleteAsync(int Id);

         SelectProduct MapToSelectProductForBusinessLogic(Product product, List<Category> ListOneCatogry);

        List<SelectExtra> MapToSelectExtra();


    }
}
