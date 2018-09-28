using SingleResponsibilityAfter.DataModels;

namespace SingleResponsibilityAfter.Services.Contracts
{
    public interface IDatabaseService
    {
        int SaveOrder(Order order);
    }
}
