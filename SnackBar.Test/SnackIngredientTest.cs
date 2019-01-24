using SnackBar.Domain.Entities;
using System;
using Xunit;

namespace SnackBar.Test
{
    public class SnackIngredientTest
    {
        public SnackIngredient GetSnacksIngredients()
        {
            return new SnackIngredient(new Ingredient(Guid.NewGuid(), "XBA", 2), 2);
        }

        [Fact]
        public void VerifyQuantityWhenAdd()
        {
            var ingredient = GetSnacksIngredients();
            ingredient.AddQuantity(1);

            Assert.Equal(3, ingredient.Quantity);
        }

        [Fact]
        public void VerifyQuantityWhenRemove()
        {
            var ingredient = GetSnacksIngredients();
            ingredient.RemoveQuantity(1);

            Assert.Equal(1, ingredient.Quantity);
        }

        [Fact]
        public void VerifyIfHasIngredient()
        {
            var ingredient = GetSnacksIngredients();
            Assert.NotNull(ingredient.Ingredient);
        }
    }
}
