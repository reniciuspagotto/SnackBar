using Microsoft.AspNetCore.Mvc;
using SnackBar.Domain.Entities;
using SnackBar.Domain.Repositories;
using System.Collections.Generic;

namespace SnackBar.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IngredientController : ControllerBase
    {
        private readonly IIngredientRepository _ingredientRepository;

        public IngredientController(IIngredientRepository ingredientRepository)
        {
            _ingredientRepository = ingredientRepository;
        }

        [HttpGet]
        public IEnumerable<Ingredient> GetAll()
        {
            var ingredients = _ingredientRepository.GetAll();
            return ingredients;
        }
    }
}
