using Microsoft.EntityFrameworkCore;
using Waffar.Context;
using System.Linq.Expressions;

namespace Waffar.GenericRepository
{
        public class GenericRepository<T> : IGenericRepository<T> where T : class
        {
            private readonly ApplicationContext _dbContext;
            private readonly DbSet<T> entities = null;
            public GenericRepository(ApplicationContext context)
            {
                _dbContext = context;
                entities = context.Set<T>();
            }
        public async Task Add(T enttity)
        {
            await _dbContext.Set<T>().AddAsync(enttity);
        }

        public IQueryable<T> GetAllAsync(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _dbContext.Set<T>();
            query = includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            return query;
        }
        public IQueryable<T> GetAll(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _dbContext.Set<T>();
            query = includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            return query;
        }
        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
