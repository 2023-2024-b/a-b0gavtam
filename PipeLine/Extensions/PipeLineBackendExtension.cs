using PipeLine.Context;
using System.Runtime.CompilerServices;

namespace PipeLine.Extensions
{
    public static class PipeLineBackendExtension
    {
        public static void AddBackend(this IServiceCollection services)
        {
            services.ConfigureCors();
        }
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(option =>
            option.AddPolicy(name: "KretaCors",
            policy =>
            {
                policy.WithOrigins("https://0.0.0.0:7020/")
                .AllowAnyHeader()
                .AllowAnyMethod();
            }
            )
           );
        }
        public static void ConfigureInMemoryTestData(this IServiceCollection services) 
        {
            string dbNameInMemoryContext = "Kreta" + Guid.NewGuid();
                services.AddDbContext<PipeLineInMemoryContext>
            (
                 options => options.UseInMemoryDatabase(databaseName: dbNameInMemoryContext),
                 ServiceLifetime.Scoped,
                 ServiceLifetime.Scoped
            );
        }   
}
