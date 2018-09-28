using SingleResponsibilityAfter.Services.Contracts;
using SingleResponsibilityAfter.ViewModels;

namespace SingleResponsibilityAfter.Services
{
    public class EmailService : IEmailService
    {
        public void Send(OrderViewModel orderViewModel, string userName)
        {
            // Send an email to the customer confirming their order
        }
    }
}
