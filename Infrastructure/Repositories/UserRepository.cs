using Domain.Models.Users;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
       public UserRepository( DbContext dbContext )
            :base( dbContext )
        { }
    }
}
