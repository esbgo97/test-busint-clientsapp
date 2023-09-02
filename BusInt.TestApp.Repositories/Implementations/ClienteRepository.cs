using BusInt.TestApp.Database;
using BusInt.TestApp.Models.Entities;
using BusInt.TestApp.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BusInt.TestApp.Repositories.Implementations
{
    public class ClienteRepository : IClienteRepository
    {
        private AppDbContext _context;
        public ClienteRepository(DbContext context)
        {
            _context = (AppDbContext)context;
        }
        public async Task<bool> Delete(Cliente entity)
        {
            var client = _context.Clientes.FirstOrDefault(c => c.Id == entity.Id);
            if (client != null)
            {
                _context.Clientes.Remove(client);
            }
            return await _context.SaveChangesAsync() > 0;
        }

        public Task<List<Cliente>> GetAll()
        {
            return _context.Clientes.ToListAsync();
        }

        public Task<int> Save(Cliente entity)
        {
            _context.Clientes.Add(entity).State = EntityState.Added;
            return _context.SaveChangesAsync();
        }

        public Task<bool> Update(Cliente entity)
        {
            throw new NotImplementedException();
        }
    }
}
