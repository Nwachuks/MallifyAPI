using System.Collections.Generic;
using System.Threading.Tasks;
using Mallify.API.Models;
using Mallify.API.Services.Communication;

namespace Mallify.API.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
        Task<SaveCategoryResponse> SaveAsync(Category category);
        Task<SaveCategoryResponse> UpdateAsync(int id, Category category);
    }
}
