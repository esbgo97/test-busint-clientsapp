using BusInt.TestApp.Database;
using BusInt.TestApp.Models.Entities;
using BusInt.TestApp.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusInt.TestApp.Repositories.Implementations
{
    public class CityRepository : ICityRepository
    {
        private readonly AppDbContext _context;
        public CityRepository(DbContext context)
        {
            _context = (AppDbContext)context;
        }
        public Task<bool> Delete(Ciudad entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Ciudad>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<Ciudad>> GetByCountryCode(string countryCode)
        {
            return _context.Ciudades.ToListAsync();
        }

        public Task<int> Save(Ciudad entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Ciudad entity)
        {
            throw new NotImplementedException();
        }
    }
}
