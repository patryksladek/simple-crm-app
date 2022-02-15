using External.TaxpayerListAPI.Models;

namespace External.TaxpayerListAPI.Interfaces
{
    public interface IVatWhiteListRepository
    {
        public Task<Customer> GetDataFromTaxNumberAsync(string taxNumber);
    }
}
