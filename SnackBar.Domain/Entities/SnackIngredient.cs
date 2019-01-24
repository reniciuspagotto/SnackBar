namespace SnackBar.Domain.Entities
{
    public class SnackIngredient
    {
        public SnackIngredient(Ingredient ingredient, int quantity)
        {
            Quantity = quantity;
            Ingredient = ingredient;
        }

        public int Quantity { get; private set; }
        public Ingredient Ingredient { get; private set; }

        public void AddQuantity(int quantity)
        {
            Quantity += quantity;
        }

        public void RemoveQuantity(int quantity)
        {
            Quantity -= quantity;
        }
    }
}
