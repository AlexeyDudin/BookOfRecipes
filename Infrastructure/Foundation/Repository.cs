using Domain.Foundation;
using Domain.Models.Users;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infrastructure.Foundation
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext DbContext;
        protected DbSet<T> Entities => DbContext.Set<T>();

        public Repository(DbContext dbContext)
        {
            DbContext = dbContext;
        }

        public T First()
        {
            return Entities.First();
        }

        public T FirstOrDefault(Expression<Func<T, bool>> predicate)
        {
            return predicate != null ? Entities.FirstOrDefault(predicate) : First();
        }

        public void Add(T entity)
        {
            Entities.Add(entity);
        }

        public void Change(T oldValues, T newValues)
        {
            if (oldValues == null)
                throw new ArgumentNullException(nameof(oldValues));
            if (newValues == null)
                throw new ArgumentNullException(nameof(newValues));
            foreach (T entity in Entities.Where(entity => entity == oldValues))
            {
                switch (entity.GetType().ToString())
                {
                    case "User":
                        User user = (entity as User);
                        user.UserName = (newValues as User).UserName;
                        user.Description = (newValues as User).Description;
                        break;
                    default:
                        return;
                }
                //TODO Нужно реализовать! Надо придумать как!
               // entity = newValues;
            }
            throw new KeyNotFoundException("Не найден искомый пользователь");
        }

        public void Delete(T entity)
        {
            if (Entities.Contains(entity))
                Entities.Remove(entity);
        }
    }
}
