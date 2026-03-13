using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConnectPayII.Models;

namespace ConnectPayII.Data
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _context = new AppDbContext();
        public void Add(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public List<Order> GetAll()
        {
            return _context.Orders.ToList();
            
        }

        public Order GetOrderById(int id)
        {
            return _context.Orders.Find(id);
        }

        public Order  Update(Order order)
        {
            var existingOrder = _context.Orders.Find(order.id);
            if (existingOrder == null)
            {
                throw new ArgumentException("Order not found");
            }


            _context.Orders.Update(order);
            _context.SaveChanges();
        }
        
        public void Delete(int id)
        {
            var order = _context.Orders.Find(id);
            if (order == null)
            {
                throw new ArgumentException("Order not found");
            }
            
            _context.Orders.Remove(order);
            _context.SaveChanges();
        }
    }
}