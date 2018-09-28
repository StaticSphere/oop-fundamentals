using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SingleResponsibilityAfter.DataModels;
using SingleResponsibilityAfter.Services.Contracts;
using SingleResponsibilityAfter.ViewModels;

namespace SingleResponsiblityAfter.Controllers
{
    [ApiController]
    public class OrdersController : Controller
    {
        private readonly IDatabaseService _databaseService;
        private readonly IWarehouseService _warehouseService;
        private readonly IEmailService _emailService;
        private readonly IMapper _mapper;

        public OrdersController(IDatabaseService databaseService, IWarehouseService warehouseService, IEmailService emailService, IMapper mapper)
        {
            _databaseService = databaseService;
            _warehouseService = warehouseService;
            _emailService = emailService;
            _mapper = mapper;
        }

        [HttpPost]
        [Route("api/order")]
        public ActionResult<int> SaveNewOrder(OrderViewModel orderViewModel)
        {
            // Mapping is now handled via a 3rd party library
            var order = _mapper.Map<Order>(orderViewModel);

            var newId = _databaseService.SaveOrder(order);
            _warehouseService.RequestPick(orderViewModel);
            _emailService.Send(orderViewModel, User.Identity.Name);

            // This method is now MUCH simpler, and has only 1 responsibility;
            // to handle the request. It offloads the actual processing of the
            // order to other entities. They, in turn, have only 1 responsibility
            // themselves. The AutoMapper service is ONLY concerned with mapping
            // data types. The warehouse service is ONLY concerned with issuing
            // pick requests to the warehouse.  Our controller is simply a delegating
            // method now. If we now find a bug in our email code, only that class
            // needs to change; our controller is left untouched.

            return newId;
        }
    }
}