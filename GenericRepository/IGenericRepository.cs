using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Waffar.GenericRepository
{
    public interface IGenericRepository<T> where T : class
    {
        Task Add(T enttity);
        IQueryable<T> GetAllAsync(params Expression<Func<T, object>>[] includeProperties);
        IQueryable<T> GetAll(params Expression<Func<T, object>>[] includeProperties);
        void SaveChanges();
    }
}
