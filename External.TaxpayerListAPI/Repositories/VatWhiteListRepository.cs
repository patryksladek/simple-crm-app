using External.TaxpayerListAPI.Interfaces;
using External.TaxpayerListAPI.Models;
using WykazPodatnikow.Core;

namespace External.TaxpayerListAPI.Repositories
{
    public class VatWhiteListRepository : IVatWhiteListRepository
    {
        private readonly VatWhiteList _vatWhiteList;
        public VatWhiteListRepository()
        {
            _vatWhiteList = new VatWhiteList(new HttpClient());
        }

        public async Task<Customer> GetDataFromTaxNumberAsync(string taxNumber)
        {
            try
            {
                var resultNip = await _vatWhiteList.GetDataFromNipAsync(taxNumber, DateTime.Now);
                if (resultNip.Exception is null)
                {
                    return new Customer()
                    {
                        Id = resultNip.Result?.RequestId,
                        Name = resultNip.Result?.Subject.Name,
                        TaxNumber = resultNip.Result?.Subject.Nip,
                        StatusVat = resultNip.Result?.Subject.StatusVat,
                        AccountNumbers = resultNip.Result?.Subject?.AccountNumbers,
                    };
                }
                else
                {
                    throw new Exception($"Wystąpił błąd podczas sprawdzania: Kod {resultNip.Exception.Code} | Komunikat: {resultNip.Exception.Message}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"[Błąd] {ex.Message}");
            }

        }
    }
}
