using SnackBar.Domain.Entities;
using SnackBar.Infra.Repositories;
using System;
using System.Collections.Generic;
using Xunit;

namespace SnackBar.Test
{
    public class SnackTest
    {
        public IEnumerable<Ingredient> CreateIngredients()
        {
            var ingredients = new IngredientRepository();
            return ingredients.GetAll();
        }

        [Fact]
        public void VerifyIngredientsOfSnack()
        {
            var snack = new Snack(Guid.NewGuid(), "XBC");
            var ingredients = CreateIngredients();

            foreach (var item in ingredients)
                snack.AddIngredient(item, 1);

            Assert.Equal(5, snack.Ingredients.Count);
        }

        [Fact]
        public void VerifySnackPrice()
        {
            var snack = new Snack(Guid.NewGuid(), "XBC");
            var ingredients = CreateIngredients();

            foreach (var item in ingredients)
                snack.AddIngredient(item, 2);

            snack.CalculatePrice();
            Assert.Equal(15.4, snack.TotalPrice);
        }

        [Fact]
        public void VerifySnackMeatPromotionPrice()
        {
            var snack = new Snack(Guid.NewGuid(), "XBC");
            var ingredients = CreateIngredients();

            foreach (var item in ingredients)
            {
                if(item.Name == "Hamburguer")
                    snack.AddIngredient(item, 3);
                else
                    snack.AddIngredient(item, 1);
            }

            snack.CalculatePrice();
            Assert.Equal(10.7, Math.Round(snack.TotalPrice, 2));
        }

        [Fact]
        public void VerifySnackCheesePromotionPrice()
        {
            var snack = new Snack(Guid.NewGuid(), "XBC");
            var ingredients = CreateIngredients();

            foreach (var item in ingredients)
            {
                if (item.Name == "Queijo")
                    snack.AddIngredient(item, 3);
                else
                    snack.AddIngredient(item, 1);
            }

            snack.CalculatePrice();
            Assert.Equal(9.2, Math.Round(snack.TotalPrice, 2));
        }

        [Fact]
        public void VerifyIfApplyLightPromotion()
        {
            var snack = new Snack(Guid.NewGuid(), "XBC");
            var ingredients = CreateIngredients();

            foreach (var item in ingredients)
            {
                if (item.Name == "Bacon")
                    snack.AddIngredient(item, 0);
                else
                    snack.AddIngredient(item, 1);
            }

            var apply = snack.ApplyLightPromotion(snack);
            Assert.True(apply);
        }
    }
}
