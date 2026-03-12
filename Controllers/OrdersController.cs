using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConnectPayII.Data;
using ConnectPayII.Models;
using ConnectPayII.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace ConnectPayII.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;

        public OrdersController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        [HttpPost]
        public IActionResult Add(OrderViewModel orderViewModel)
        {
            var order = new Order(orderViewModel.service, orderViewModel.value, orderViewModel.endDate, orderViewModel.subscriptionId, orderViewModel.expirationDate);
           
            _orderRepository.Add(order);
            return Ok(order);
        }

        public IActionResult GetResult(OrderViewModel orderViewModel)
        {
            var order = _orderRepository.GetOrderById(orderViewModel.id);
            if(order == null)
            {
                return NotFound();
            }
            return Ok(order);
        }
    }
}