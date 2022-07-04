using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infrastructure.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly DbContext DbContext;
        protected DbSet<T> Entities => DbContext.Set<T>();

        public BaseRepository( DbContext dbContext )
        {
            DbContext = dbContext;
        }

        public T First()
        {
            return Entities.First();
        }

        public T FirstOrDefault( Expression<Func<T, bool>> predicate )
        {
            return predicate != null ? Entities.FirstOrDefault( predicate ) : First();
        }
    }
}
