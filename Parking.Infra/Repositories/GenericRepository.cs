using Parking.Infra.Context;

namespace Parking.Infra.Repositories;

public class GenericRepository<T> : IRepository<T> where T : class
{
    private readonly ParkingContext _context;

    public GenericRepository(ParkingContext context){
        _context = context;
    }

    public async Task AddAsync(T entity)
    {
       await _context.Set<T>().AddAsync(entity);
    }
    public async Task UpdateAsync(T entity){}
     public async Task DeleteAsync(T entity){}
     public IQueryable<T> Get(){return}
}