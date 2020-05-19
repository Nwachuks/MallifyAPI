using System;
using System.Threading.Tasks;
using Mallify.API.Persistence.Contexts;
using Mallify.API.Repositories;

namespace Mallify.API.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
