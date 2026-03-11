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

        public void Update(Order order)
        {
            _context.Orders.Update(order);
            _context.SaveChanges();
        }
    }
}