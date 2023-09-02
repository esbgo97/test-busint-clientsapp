using BusInt.TestApp.Database;
using BusInt.TestApp.Models.Entities;
using BusInt.TestApp.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BusInt.TestApp.Repositories.Implementations
{
    public class PaisRepository : IPaisRepository
    {
        private AppDbContext _context;
        public PaisRepository(DbContext context)
        {
                
            _context = (AppDbContext)context;
        }
        public Task<bool> Delete(Pais entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Pais>> GetAll()
        {
            return _context.Paises.ToListAsync();
        }

        public Task<int> Save(Pais entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Pais entity)
        {
            throw new NotImplementedException();
        }
    }
}
