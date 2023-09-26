using Microsoft.EntityFrameworkCore;
using User.Domain.Interfaces.Repositories;
using User.Infrastructure.Data;

namespace User.Infrastructure.Repositories
{
    public class UserRepository : BaseRepository<Domain.Entities.User>, IUserRepository
    {
        public UserRepository(UserDbContext context) : base(context)
        {
        }

        public async Task<Domain.Entities.User> GetByUsername(string username) => await _context.Users.FirstOrDefaultAsync(u => u.Username == username && u.IsActive);
        
    }
}
