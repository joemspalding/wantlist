using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WantList.Domain.Abstract;
using WantList.Domain.Objects;

namespace WantList.Infrastructure.Data
{
    public class CategoryRepository : ICategoryRepository
    {
        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            using(var context = new WantListContext())
            {
                return await context.Categories
                    .Select(x => x)
                    .ToListAsync();
            }
        }

        public async Task<Category> GetCategoryByIdAsync(int categoryId)
        {
            using(var context = new WantListContext())
            {
                return await context.Categories
                    .Where(x=> x.CategoryId == categoryId)
                    .Select(x => x)
                    .FirstOrDefaultAsync();
            }
        }
    }
}
