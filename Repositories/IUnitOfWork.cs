using System;
using System.Threading.Tasks;

namespace Mallify.API.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
