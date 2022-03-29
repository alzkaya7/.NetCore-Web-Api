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
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Category> GetSingleCategoryByIdWithProductAsync(int categoryId)
        {

            //Categoryleri ıdleryle beraber ürünlerini getirsin ..
            return await _context.Categories.Include(x=>x.Products).Where(x=>x.Id==categoryId).SingleOrDefaultAsync();
        }
    }
}
