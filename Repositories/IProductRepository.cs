using System.Collections.Generic;
using System.Threading.Tasks;
using Mallify.API.Models;

namespace Mallify.API.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> ListAsync();
    }
}