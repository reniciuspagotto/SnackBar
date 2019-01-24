using System;
using System.Collections.Generic;

namespace SnackBar.Domain.Commands
{
    public class OrderSnackCommand
    {
        public OrderSnackCommand()
        {
            Ingredients = new List<OrderSnackIngredientCommand>();
        }

        public Guid Id { get; set; }
        public List<OrderSnackIngredientCommand> Ingredients { get; set; }
    }
}
