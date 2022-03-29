﻿using Microsoft.EntityFrameworkCore;
using Nlayer.Core;
using Nlayer.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nlayer.Repository.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {


        }

        public async Task<List<Product>> GetProductsWithCategory()
        {

            //Producta ait categoryleri beraberinde getir  .. Eager Loading  ..
             return await _context.Products.Include(x=>x.Category).ToListAsync();
        }
    }
}
