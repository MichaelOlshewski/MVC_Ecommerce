using System.Linq.Expressions;

namespace Ecommerce.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        // T - Product
        T GetFirstOrDefault(Expression<Func<T, bool>> filter, string? includesProperties = null, bool tracked = true);

        IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null, string? includeProperties = null);

        void Add(T entity);

        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entity);
    }
}
