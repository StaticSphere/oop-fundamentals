using SingleResponsibilityAfter.ViewModels;

namespace SingleResponsibilityAfter.Services.Contracts
{
    public interface IWarehouseService
    {
        void RequestPick(OrderViewModel orderViewModel);
    }
}
