﻿using System;

namespace SnackBar.Shared.BaseEntity
{
    public class Entity
    {
        public Guid Id { get; private set; }

        protected void NewOrSetIdEntity(Guid id)
        {
            if (id == Guid.Empty)
                Id = Guid.NewGuid();
            else
                Id = id;
        }
    }
}
