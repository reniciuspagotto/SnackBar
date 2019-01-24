using SnackBar.Shared.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SnackBar.Domain.Entities
{
    public class Snack : Entity
    {
        public Snack(Guid id, string name)
        {
            NewOrSetIdEntity(id);
            Name = name;
            Ingredients = new List<SnackIngredient>();
        }

        public string Name { get; private set; }
        public List<SnackIngredient> Ingredients { get; private set; }
        public double TotalPrice { get; set; }

        public void AddIngredient(Ingredient ingredient, int quantity)
        {
            if(ingredient != null)
            {
                var snackIngredient = new SnackIngredient(ingredient, quantity);
                Ingredients.Add(snackIngredient);
            }
        }

        public void CalculatePrice()
        {
            foreach (var item in Ingredients)
            {
                if(item.Ingredient.Name == "Hamburguer")
                {
                    var quantityPay = item.Quantity - (item.Quantity / 3);
                    TotalPrice += item.Ingredient.Price * quantityPay;
                }
                else if(item.Ingredient.Name == "Queijo")
                {
                    var quantityPay = item.Quantity - (item.Quantity / 3);
                    TotalPrice += item.Ingredient.Price * quantityPay;
                }
                else {
                    TotalPrice += item.Ingredient.Price * item.Quantity;
                }
            }
        }

        public bool ApplyLightPromotion(Snack snack)
        {
            var alface = Ingredients.Where(p => p.Ingredient.Name.ToUpper() == "ALFACE" && p.Quantity > 0).ToList();
            var bacon = Ingredients.Where(p => p.Ingredient.Name.ToUpper() == "BACON" && p.Quantity > 0).ToList();

            if (alface.Count > 0 && bacon.Count > 0)
                return false;

            return true;
        }
    }
}
