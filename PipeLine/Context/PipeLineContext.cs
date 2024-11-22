using Microsoft.EntityFrameworkCore;

namespace PipeLine.Context
{
    public class PipeLineContext : DbContext
    {
        protected PipeLineContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
    }
}
