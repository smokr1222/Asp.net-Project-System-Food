

using systemFood.ViewModel.SessionViewModel;

namespace systemFood.Services.Interface
{
    public interface IOrderService
    {

        Task SaveOrderServr( OrderModel orderModels);
        string NewOrder();


    }
}
