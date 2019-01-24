using SnackBar.Domain.Entities;
using System;
using System.Collections.Generic;

namespace SnackBar.Domain.Repositories
{
    public interface ISnackRepository
    {
        IEnumerable<Snack> GetAll();
        Snack GetById(Guid id);
    }
}
