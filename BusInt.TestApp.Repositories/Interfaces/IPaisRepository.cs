using BusInt.TestApp.Models.Entities;

namespace BusInt.TestApp.Repositories.Interfaces
{
    public interface IPaisRepository :IEntityRepository<Pais>
    {
        Task<Pais> GetByCodeAsync(string code);

    }
}
