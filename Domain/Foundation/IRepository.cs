using System.Linq.Expressions;

namespace Domain.Foundation
{
    public interface IRepository<T> where T : class
    {
        T First();

        T FirstOrDefault(Expression<Func<T, bool>> predicate);

        void Add(T entity);
        void Change(T oldValues, T newValues);
        void Delete(T entity);
    }
}
