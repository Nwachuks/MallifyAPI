using System.Collections.Generic;
using System.Threading.Tasks;
using Mallify.API.Models;
using Mallify.API.Services.Communication;

namespace Mallify.API.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
        Task<CategoryResponse> SaveAsync(Category category);
        Task<CategoryResponse> UpdateAsync(int id, Category category);
        Task<CategoryResponse> DeleteAsync(int id);
    }
}
