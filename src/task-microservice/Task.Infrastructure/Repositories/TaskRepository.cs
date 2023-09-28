using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class TaskRepository : BaseRepository<Domain.Entities.Task>, ITaskRepository
    {
        public TaskRepository(TaskDbContext context) : base(context)
        {
        }

        public async Task<List<Domain.Entities.Task>> GetTaskByUserId(long userId) => await _context.Tasks.Where(t => t.UserId == userId).ToListAsync();
    }
}
