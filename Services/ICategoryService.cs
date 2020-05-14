using System.Collections.Generic;
using System.Threading.Tasks;
using Mallify.API.Models;

namespace Mallify.API.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}
