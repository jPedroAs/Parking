namespace Parking.Infra.Repositories;
public interface IRepository<T>
{
    IQueryable<T> Get();
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
    Task AddAsync(T entity);
}