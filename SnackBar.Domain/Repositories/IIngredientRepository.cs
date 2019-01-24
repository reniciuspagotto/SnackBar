using SnackBar.Domain.Entities;
using System;
using System.Collections.Generic;

namespace SnackBar.Domain.Repositories
{
    public interface IIngredientRepository
    {
        IEnumerable<Ingredient> GetAll();
        Ingredient GetById(Guid id);
    }
}
