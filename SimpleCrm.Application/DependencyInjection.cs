using Microsoft.Extensions.DependencyInjection;
using SimpleCrm.Application.Interfaces;
using SimpleCrm.Application.Services;
using System.Reflection;

namespace SimpleCrm.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddScoped<ICustomerService, CustomerService>();
            return services;
        }
    }
}
