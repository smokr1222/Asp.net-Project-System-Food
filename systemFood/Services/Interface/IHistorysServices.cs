namespace systemFood.Services.Interface
{
    public interface IHistorysServices
    {
        IEnumerable<Orders> GetHistoryListForBusinessLogic();
    }
}
