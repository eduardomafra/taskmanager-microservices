using Microsoft.EntityFrameworkCore;
using Task.Domain.Entities;

namespace Task.Infrastructure.Data
{
    public class TaskDbContext : DbContext
    {
        public TaskDbContext(DbContextOptions<TaskDbContext> options) : base(options) { }

        public DbSet<Domain.Entities.Task> Tasks { get; set; }
        public DbSet<Subtask> Subtasks { get; set; }
    }
}
