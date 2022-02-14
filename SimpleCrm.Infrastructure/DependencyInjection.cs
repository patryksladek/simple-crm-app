using Microsoft.Extensions.DependencyInjection;
using SimpleCrm.Domain.Interfaces;
using SimpleCrm.Infrastructure.Repositories;

namespace SimpleCrm.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<ICustomerRepository, CustomerRepository>();
            return services;
        }
    }
}
