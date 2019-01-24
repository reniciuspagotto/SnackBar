using SnackBar.Domain.Entities;
using SnackBar.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SnackBar.Infra.Repositories
{
    public class IngredientRepository : IIngredientRepository
    {
        public List<Ingredient> Ingredients { get; }

        public IngredientRepository()
        {
            Ingredients = new List<Ingredient>
            {
                new Ingredient(Guid.Parse("34d71f7b-7ad6-4bb1-8689-4a4fed5b3a7a"), "Alface", 0.40),
                new Ingredient(Guid.Parse("5d77453a-d4a8-4d15-8acc-a71a897da811"), "Bacon", 2.00),
                new Ingredient(Guid.Parse("914fbbb3-985a-43ee-a17f-fd5fbc40499d"), "Hamburguer", 3.00),
                new Ingredient(Guid.Parse("b00c92d0-9708-4c0b-8b53-0420516c69f8"), "Ovo", 0.80),
                new Ingredient(Guid.Parse("40b0764c-ec61-4d1a-8b1e-51160ec50d7c"), "Queijo", 1.50)
            };
        }

        public IEnumerable<Ingredient> GetAll()
        {
            return Ingredients;
        }

        public Ingredient GetById(Guid id)
        {
            return Ingredients.FirstOrDefault(x => x.Id == id);
        }
    }
}