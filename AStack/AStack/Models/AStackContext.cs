using Microsoft.EntityFrameworkCore;

namespace AStack.Models
{
    public class AStackContext : DbContext
    {
        public AStackContext(DbContextOptions<AStackContext> options)
            : base(options)
        {
        }

        public DbSet<AStackItem> TodoItems { get; set; }
    }
}
