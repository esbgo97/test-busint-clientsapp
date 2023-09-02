using Microsoft.Extensions.DependencyInjection;

namespace BusInt.TestApp.Database
{
    public static class DatabaseStartup
    {
        public static void AddDatabase(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>();
        }
    }
}