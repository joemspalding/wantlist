using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WantList.Domain.Objects;

namespace WantList.Domain.Abstract
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetCategoriesAsync();
        Task<Category> GetCategoryByIdAsync(int categoryId);
    }
}
