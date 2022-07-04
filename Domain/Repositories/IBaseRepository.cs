using System.Linq.Expressions;

namespace Domain.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        T First();

        T FirstOrDefault( Expression<Func<T, bool>> predicate );
    }
}
