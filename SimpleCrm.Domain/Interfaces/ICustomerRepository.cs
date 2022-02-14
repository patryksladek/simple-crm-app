using SimpleCrm.Domain.Entities;

namespace SimpleCrm.Domain.Interfaces
{
    public interface ICustomerRepository
    {
        Customer GetById(Guid id);

        Customer GetByTaxNumber(string taxNumber);

        IQueryable<Customer> GetAll();
    }
}
