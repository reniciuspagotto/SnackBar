using Microsoft.AspNetCore.Mvc;
using SnackBar.Domain.Commands;
using SnackBar.Domain.Entities;
using SnackBar.Domain.Handlers;
using SnackBar.Domain.Repositories;
using System.Collections;
using System.Collections.Generic;

namespace SnackBar.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly OrderHandler _orderHandler;
        private readonly IOrderRepository _orderRepository;

        public OrderController(OrderHandler orderHandler, IOrderRepository orderRepository)
        {
            _orderHandler = orderHandler;
            _orderRepository = orderRepository;
        }

        [HttpPost]
        public void Save(OrderCommand command)
        {
            _orderHandler.Handle(command);
        }

        [HttpGet]
        public IEnumerable<Order> GetAll()
        {
            return _orderRepository.GetAll();
        }
    }
}
