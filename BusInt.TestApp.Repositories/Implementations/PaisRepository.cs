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

        public Task<Pais> GetByCodeAsync(string code)
        {
            return _context.Paises.FirstOrDefaultAsync(p => p.Codpais == code);
        }

        public async Task<int> Save(Pais entity)
        {

            var pais = await GetByCodeAsync(entity.Codpais);

            if(pais != null)
            {
                throw new ApplicationException($"Ya existe el pais con el codigo {entity.Codpais}");
            }

            _context.Paises.Add(entity).State = EntityState.Added;
            return await _context.SaveChangesAsync();
                 
        }

        public Task<bool> Update(Pais entity)
        {
            throw new NotImplementedException();
        }
    }
}
