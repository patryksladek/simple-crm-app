using SimpleCrm.Application.Dto;

namespace SimpleCrm.Application.Interfaces
{
    public interface ICustomerService
    {
        IEnumerable<CustomerDto> GetAllCustomers();
        CustomerDto GetCustomerById(Guid id);
        CustomerDto GetCustomerByTaxNumber(string taxNumber);
        IEnumerable<CustomerReportDto> GetAllCustomers4Report();
    }
}
