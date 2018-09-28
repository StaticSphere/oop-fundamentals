using SingleResponsibilityAfter.DataModels;
using SingleResponsibilityAfter.Services.Contracts;

namespace SingleResponsibilityAfter.Services
{
    public class DatabaseService : IDatabaseService
    {
        public int SaveOrder(Order order)
        {
            // Save the order to the database.

            return 1;
        }
    }
}
