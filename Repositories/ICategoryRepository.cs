using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Mallify.API.Models;

namespace Mallify.API.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> ListAsync();
        Task AddAsync(Category category);
        Task<Category> FindByIdAsync(int id);
        void Update(Category category);
    }
}
