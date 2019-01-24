using SnackBar.Shared.BaseEntity;
using System;
using System.Collections.Generic;

namespace SnackBar.Domain.Entities
{
    public class Order : Entity
    {
        public Order(Guid id)
        {
            NewOrSetIdEntity(id);
            Snacks = new List<Snack>();
        }

        public List<Snack> Snacks { get; private set; }
        public double TotalPrice { get; private set; }

        public void AddSnack(Snack snack)
        {
            if (snack != null)
            {
                var apply = snack.ApplyLightPromotion(snack);
                Snacks.Add(snack);

                if (apply)
                    TotalPrice += (snack.TotalPrice - (snack.TotalPrice * 0.1));
                else
                    TotalPrice += snack.TotalPrice;
            }
        }
    }
}
