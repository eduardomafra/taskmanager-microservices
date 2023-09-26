using User.Domain.Interfaces.Repositories;
using User.Infrastructure.Data;

namespace User.Infrastructure.Repositories
{
    public class UserRepository : BaseRepository<Domain.Entities.User>, IUserRepository
    {
        public UserRepository(UserDbContext context) : base(context)
        {
        }
    }
}
