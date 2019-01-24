using SnackBar.Domain.Entities;
using System;
using System.Collections.Generic;

namespace SnackBar.Domain.Repositories
{
    public interface IOrderRepository
    {
        void Save(Order order);
        Order GetById(Guid id);
        IEnumerable<Order> GetAll();
    }
}
