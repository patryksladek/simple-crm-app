using External.TaxpayerListAPI.Interfaces;
using External.TaxpayerListAPI.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace External.TaxpayerListAPI
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddExternalTaxpayerListApi(this IServiceCollection services)
        {
            services.AddSingleton<IVatWhiteListRepository, VatWhiteListRepository>();
            services.AddSingleton<ITaxpayerListApiClient, TaxpayerListApiClient>();
            return services;
        }
    }
}
