using SnackBar.Domain.Entities;
using SnackBar.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SnackBar.Infra.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public List<Order> Orders { get; set; }

        public OrderRepository()
        {
            Orders = new List<Order>();
        }

        public void Save(Order order)
        {
            Orders.Add(order);
        }

        public Order GetById(Guid id)
        {
            return Orders.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Order> GetAll()
        {
            return Orders;
        }
    }
}
