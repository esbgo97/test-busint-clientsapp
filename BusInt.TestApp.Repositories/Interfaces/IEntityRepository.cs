namespace BusInt.TestApp.Repositories.Interfaces
{
    public interface IEntityRepository<T>
    {
        Task<int> Save(T entity);
        Task<bool> Update(T entity);
        Task<bool> Delete(T entity);
        Task<List<T>> GetAll();
    }
}
