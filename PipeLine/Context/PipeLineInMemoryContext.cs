using Microsoft.EntityFrameworkCore;
namespace PipeLine.Context
{
    public class PipeLineInMemoryContext : PipeLineContext
    {
        protected PipeLineInMemoryContext(DbContextOptions options) : base(options)
        {

        }
    }
}
