using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnectPayII.Models
{
    public interface IOrderRepository
    {
        void Add(Order order);
        void Update(Order order);

        List<Order> GetAll();

        Order GetOrderById(int id);
    }
}