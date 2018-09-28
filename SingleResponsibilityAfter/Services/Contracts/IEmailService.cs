using SingleResponsibilityAfter.ViewModels;

namespace SingleResponsibilityAfter.Services.Contracts
{
    public interface IEmailService
    {
        void Send(OrderViewModel orderViewModel, string userName);
    }
}
