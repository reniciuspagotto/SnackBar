using SnackBar.Shared.BaseEntity;
using System;

namespace SnackBar.Domain.Entities
{
    public class Ingredient : Entity
    {
        public Ingredient(Guid id, string name, double price)
        {
            NewOrSetIdEntity(id);
            Name = name;
            Price = price;
        }

        public string Name { get; private set; }
        public double Price { get; set; }
    }
}
