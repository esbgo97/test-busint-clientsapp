using BusInt.TestApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusInt.TestApp.Repositories.Interfaces
{
    public interface ICityRepository :IEntityRepository<Ciudad>
    {
        Task<List<Ciudad>> GetByCountryCode(string countryCode); 
    }
}
