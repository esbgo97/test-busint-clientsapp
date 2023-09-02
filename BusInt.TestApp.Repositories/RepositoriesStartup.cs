using BusInt.TestApp.Repositories.Implementations;
using BusInt.TestApp.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BusInt.TestApp.Repositories
{
    public static class RepositoriesStartup
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IClienteRepository, ClienteRepository>();
        }
    }
}