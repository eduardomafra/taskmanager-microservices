using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    public interface ITaskRepository : IBaseRepository<Entities.Task>
    {
        Task<List<Entities.Task>> GetTaskByUserId(long userId);
    }
}
