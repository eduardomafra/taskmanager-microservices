namespace User.Domain.Interfaces.Repositories
{
    public interface IUserRepository : IBaseRepository<Entities.User>
    {
        Task<Entities.User> GetByUsername(string username);
    }
}
