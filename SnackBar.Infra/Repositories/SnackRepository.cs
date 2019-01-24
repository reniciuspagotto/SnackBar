using SnackBar.Domain.Entities;
using SnackBar.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SnackBar.Infra.Repositories
{
    public class SnackRepository : ISnackRepository
    {
        private readonly IIngredientRepository _ingredientRepository;
        public List<Snack> Snacks { get; }

        public SnackRepository(IIngredientRepository ingredientRepository)
        {
            _ingredientRepository = ingredientRepository;
            Snacks = new List<Snack>();
            CreateXBacon();
            CreateXBurguer();
            CreateXEgg();
            CreateXEggBacon();
        }

        private void CreateXBacon()
        {
            var ingredient1 = _ingredientRepository.GetById(Guid.Parse("34d71f7b-7ad6-4bb1-8689-4a4fed5b3a7a"));
            var ingredient2 = _ingredientRepository.GetById(Guid.Parse("5d77453a-d4a8-4d15-8acc-a71a897da811"));
            var ingredient3 = _ingredientRepository.GetById(Guid.Parse("914fbbb3-985a-43ee-a17f-fd5fbc40499d"));
            var ingredient4 = _ingredientRepository.GetById(Guid.Parse("b00c92d0-9708-4c0b-8b53-0420516c69f8"));
            var ingredient5 = _ingredientRepository.GetById(Guid.Parse("40b0764c-ec61-4d1a-8b1e-51160ec50d7c"));
            var snack = new Snack(Guid.Parse("4b1fb2e1-8e31-44d8-b2da-a3d32d89c3d1"), "X-BACON");
            snack.AddIngredient(ingredient1, 0);
            snack.AddIngredient(ingredient2, 1);
            snack.AddIngredient(ingredient3, 1);
            snack.AddIngredient(ingredient4, 0);
            snack.AddIngredient(ingredient5, 1);
            Snacks.Add(snack);
        }

        private void CreateXBurguer()
        {
            var ingredient1 = _ingredientRepository.GetById(Guid.Parse("34d71f7b-7ad6-4bb1-8689-4a4fed5b3a7a"));
            var ingredient2 = _ingredientRepository.GetById(Guid.Parse("5d77453a-d4a8-4d15-8acc-a71a897da811"));
            var ingredient3 = _ingredientRepository.GetById(Guid.Parse("914fbbb3-985a-43ee-a17f-fd5fbc40499d"));
            var ingredient4 = _ingredientRepository.GetById(Guid.Parse("b00c92d0-9708-4c0b-8b53-0420516c69f8"));
            var ingredient5 = _ingredientRepository.GetById(Guid.Parse("40b0764c-ec61-4d1a-8b1e-51160ec50d7c"));
            var snack = new Snack(Guid.Parse("b3766f0c-988e-4025-bbe8-edfa4db941d3"), "X-BURGUER");
            snack.AddIngredient(ingredient1, 0);
            snack.AddIngredient(ingredient2, 0);
            snack.AddIngredient(ingredient3, 1);
            snack.AddIngredient(ingredient4, 0);
            snack.AddIngredient(ingredient5, 1);
            Snacks.Add(snack);
        }

        private void CreateXEgg()
        {
            var ingredient1 = _ingredientRepository.GetById(Guid.Parse("34d71f7b-7ad6-4bb1-8689-4a4fed5b3a7a"));
            var ingredient2 = _ingredientRepository.GetById(Guid.Parse("5d77453a-d4a8-4d15-8acc-a71a897da811"));
            var ingredient3 = _ingredientRepository.GetById(Guid.Parse("914fbbb3-985a-43ee-a17f-fd5fbc40499d"));
            var ingredient4 = _ingredientRepository.GetById(Guid.Parse("b00c92d0-9708-4c0b-8b53-0420516c69f8"));
            var ingredient5 = _ingredientRepository.GetById(Guid.Parse("40b0764c-ec61-4d1a-8b1e-51160ec50d7c"));
            var snack = new Snack(Guid.Parse("085f1e71-6250-4685-9549-11a887c4d969"), "X-EGG");
            snack.AddIngredient(ingredient1, 0);
            snack.AddIngredient(ingredient2, 0);
            snack.AddIngredient(ingredient3, 1);
            snack.AddIngredient(ingredient4, 1);
            snack.AddIngredient(ingredient5, 1);
            Snacks.Add(snack);
        }

        private void CreateXEggBacon()
        {
            var ingredient1 = _ingredientRepository.GetById(Guid.Parse("34d71f7b-7ad6-4bb1-8689-4a4fed5b3a7a"));
            var ingredient2 = _ingredientRepository.GetById(Guid.Parse("5d77453a-d4a8-4d15-8acc-a71a897da811"));
            var ingredient3 = _ingredientRepository.GetById(Guid.Parse("914fbbb3-985a-43ee-a17f-fd5fbc40499d"));
            var ingredient4 = _ingredientRepository.GetById(Guid.Parse("b00c92d0-9708-4c0b-8b53-0420516c69f8"));
            var ingredient5 = _ingredientRepository.GetById(Guid.Parse("40b0764c-ec61-4d1a-8b1e-51160ec50d7c"));
            var snack = new Snack(Guid.Parse("5d903a48-7e78-4480-bae9-dc18a5b83a26"), "X-EGG BACON");
            snack.AddIngredient(ingredient1, 0);
            snack.AddIngredient(ingredient2, 1);
            snack.AddIngredient(ingredient3, 1);
            snack.AddIngredient(ingredient4, 1);
            snack.AddIngredient(ingredient5, 1);
            Snacks.Add(snack);
        }

        public IEnumerable<Snack> GetAll()
        {
            return Snacks;
        }

        public Snack GetById(Guid id)
        {
            return Snacks.FirstOrDefault(p => p.Id == id);
        }
    }
}
