using Microsoft.EntityFrameworkCore;

namespace MealyBT.Models
{
    public class MealyContext:DbContext
    {
        public MealyContext(DbContextOptions<MealyContext> options) : base(options)
        {
        }
        
        public DbSet<Task> Tasks { get; set; }
    }
}