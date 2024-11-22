using PipeLine.Context;

namespace PipeLine.Extensions
{
    public static class WebApplicationExtension
    {
        public static void ConfigureWebApp(this WebApplication app)
        {
            
        }
        public static void ConfigureWebAppCors(this WebApplication app)
        {
            app.UseCors("PipeLineCors");
        }
        private static void ConfigureInMemoryTestData(this WebApplication app)
        {
            using (var scope = app.Services.CreateAsyncScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<PipeLineInMemoryContext>();
                // InMemory test data
                dbContext.Database.EnsureCreated();
            }
        }
    }
}
