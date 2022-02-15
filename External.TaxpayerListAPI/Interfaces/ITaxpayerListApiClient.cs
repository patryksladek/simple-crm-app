using External.TaxpayerListAPI.Models;

namespace External.TaxpayerListAPI.Interfaces
{
    public interface ITaxpayerListApiClient
    {
        public Task<Customer> GetCustomerDataFromTaxNumberAsync(string taxNumber);
    }
}
