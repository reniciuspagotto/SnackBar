using System;

namespace SnackBar.Domain.Commands
{
    public class OrderSnackIngredientCommand
    {
        public Guid IngredientId { get; set; }
        public int Quantity { get; set; }
    }
}
