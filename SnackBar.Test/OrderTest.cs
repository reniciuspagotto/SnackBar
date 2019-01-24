using SnackBar.Domain.Entities;
using SnackBar.Infra.Repositories;
using System;
using System.Collections.Generic;
using Xunit;

namespace SnackBar.Test
{
    public class OrderTest
    {
        public IEnumerable<Ingredient> CreateIngredients()
        {
            var ingredients = new IngredientRepository();
            return ingredients.GetAll();
        }

        public void AddAllIngredientAndQuantity(Snack snack, IEnumerable<Ingredient> ingredients, int quantity)
        {
            foreach (var item in ingredients)
                snack.AddIngredient(item, quantity);

            snack.CalculatePrice();
        }

        public void AddSpecificIngredientAndQuantity(Snack snack, IEnumerable<Ingredient> ingredients, int quantity)
        {
            foreach (var item in ingredients)
            {
                if (item.Name != "Bacon")
                    snack.AddIngredient(item, quantity);
            }

            snack.CalculatePrice();
        }

        [Fact]
        public void VerifyPriceOfOrder()
        {
            var order = new Order(Guid.NewGuid());
            var ingredients = CreateIngredients();

            for (int i = 0; i < 3; i++)
            {
                var snack = new Snack(Guid.NewGuid(), "XBC");
                AddAllIngredientAndQuantity(snack, ingredients, 2);
                order.AddSnack(snack);
            }

            Assert.Equal(46.2, order.TotalPrice);
        }

        [Fact]
        public void VerifyPriceWithLightPromotion()
        {
            var order = new Order(Guid.NewGuid());
            var ingredients = CreateIngredients();

            for (int i = 0; i < 3; i++)
            {
                var snack = new Snack(Guid.NewGuid(), "XBC");
                AddSpecificIngredientAndQuantity(snack, ingredients, 1);
                order.AddSnack(snack);
            }

            Assert.Equal(15.39, order.TotalPrice);
        }
    }
}
