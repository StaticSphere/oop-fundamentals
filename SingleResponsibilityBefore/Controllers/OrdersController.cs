using Microsoft.AspNetCore.Mvc;
using SingleResponsibilityBefore.DataModels;
using SingleResponsibilityBefore.ViewModels;

namespace SingleResponsibilityBefore.Controllers
{
    [ApiController]
    public class OrdersController : Controller
    {
        [HttpPost]
        [Route("api/order")]
        public ActionResult<int> SaveNewOrder(OrderViewModel orderViewModel)
        {
            // Most of this code is pseudo code, and is meant to illustrate the
            // point of this principle, rather than being a full, true application.
            // But you'll notice that there is a LOT of responsiblitiy going on
            // in the SaveNewOrder method. First, it is responsible for handling
            // an HTTP request to save an order. Second, it must transform the data
            // from the view model to a data model. Third, it saves the order
            // to the database.  Fourth, it sends a request to the warehouse
            // for the order to be picked. Finally, it sends a confirmation
            // email to the customer. We'll clean that up in the After project.

            // First we transform the view model object into a data model object
            var order = new Order
            {
                ItemId = orderViewModel.ItemId,
                Quantity = orderViewModel.Quantity,
                Expedite = orderViewModel.Expedite
            };

            // Next we save the data model object to our database
            // var newId = Db.SaveOrder(order);

            // Now we'll send a pick order to our warehousing system
            // Warehouse.RequestPick(orderViewModel);

            // Finally, we'll send a confirmation email to the customer
            // Email.Send(orderViewModel, User.Identity.Name);

            return 1; // return newId;
        }
    }
}