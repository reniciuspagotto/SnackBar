using SnackBar.Domain.Commands;
using SnackBar.Domain.Entities;
using SnackBar.Domain.Repositories;
using SnackBar.Shared.BaseHandler;
using System;

namespace SnackBar.Domain.Handlers
{
    public class OrderHandler : IHandler<OrderCommand>
    {
        private readonly ISnackRepository _snackRepository;
        private readonly IIngredientRepository _ingredientRepository;
        private readonly IOrderRepository _orderRepository;

        public OrderHandler(ISnackRepository snackRepository, IIngredientRepository ingredientRepository, IOrderRepository orderRepository)
        {
            _snackRepository = snackRepository;
            _ingredientRepository = ingredientRepository;
            _orderRepository = orderRepository;
        }

        public void Handle(OrderCommand command)
        {
            if (command.Snacks.Count > 0)
            {
                var order = new Order(Guid.Empty);

                foreach (var snackCommand in command.Snacks)
                {
                    var snackDb = _snackRepository.GetById(snackCommand.Id);
                    var newSnack = new Snack(snackDb.Id, snackDb.Name);

                    if (snackDb != null)
                    {
                        if (snackCommand.Ingredients.Count != 0)
                        {
                            foreach (var item in snackCommand.Ingredients)
                            {
                                var ingredient = _ingredientRepository.GetById(item.IngredientId);
                                newSnack.AddIngredient(ingredient, item.Quantity);
                            }

                            newSnack.CalculatePrice();
                            order.AddSnack(newSnack);
                        }
                    }
                }

                _orderRepository.Save(order);
            }
        }
    }
}
