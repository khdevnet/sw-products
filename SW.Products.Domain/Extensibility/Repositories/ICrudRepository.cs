﻿using System;
using System.Collections.Generic;

namespace SW.Products.Domain.Extensibility.Repositories
{
    public interface ICrudRepository<TEntity, TId> where TEntity : class
    {
        TEntity Get(TId id);

        IEnumerable<TEntity> Get();

        TEntity Add(TEntity product);

        TId Delete(TId id);
    }
}