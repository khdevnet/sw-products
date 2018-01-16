﻿using System.Collections.Generic;
using System.Linq;
using Warehouse.Products.Domain.Extensibility.Repositories;
using Warehouse.Products.Domain.Models;

namespace Warehouse.Products.Infrastructure.PostgreSQLDataAccess.Repositories
{
    internal class ProductRepository : IProductRepository
    {
        private readonly ShopDbContext context;

        public ProductRepository(ShopDbContext context)
        {
            this.context = context;
        }

        public Product Add(Product product)
        {
            context.Add(product);
            context.SaveChanges();
            return product;
        }

        public int Delete(int id)
        {
            context.Remove(Get(id));
            return context.SaveChanges();
        }

        public Product Get(int id)
        {
            return context.Products.Find(id);
        }

        public IEnumerable<Product> Get()
        {
            return context.Products.ToList();
        }
    }
}