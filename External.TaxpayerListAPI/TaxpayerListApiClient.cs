using External.TaxpayerListAPI.Interfaces;
using External.TaxpayerListAPI.Models;
using External.TaxpayerListAPI.Repositories;
using WykazPodatnikow.Core;
using WykazPodatnikow.Data;

namespace External.TaxpayerListAPI
{
    public class TaxpayerListApiClient : ITaxpayerListApiClient
    {
        private readonly IVatWhiteListRepository _vatWhiteListRepository;

        public TaxpayerListApiClient(IVatWhiteListRepository vatWhiteListRepository)
        {
            _vatWhiteListRepository = vatWhiteListRepository;
        }

        public async Task<Customer> GetCustomerDataFromTaxNumberAsync(string taxNumber)
        {
            return await _vatWhiteListRepository.GetDataFromTaxNumberAsync(taxNumber);
        }
    }
}