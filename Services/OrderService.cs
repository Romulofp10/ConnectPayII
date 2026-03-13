using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConnectPayII.Models;
using ConnectPayII.ViewModel;

namespace ConnectPayII.Services
{
    public interface IOrderService
    {
        Order Add(OrderViewModel order);
         Order Update(OrderUpdateViewModel order);
         List<Order> GetAll();
         Order GetOrderById(int id);
    }
    public class OrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }


        public Order Add(Order order)
        {
            
        }
        
    }
}