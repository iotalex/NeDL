using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class LogItemContext : DbContext
    {
        public LogItemContext(DbContextOptions<LogItemContext> options)
            : base(options)
        {
        }

        public DbSet<LogItem> LogItems { get; set; }
    }
}
