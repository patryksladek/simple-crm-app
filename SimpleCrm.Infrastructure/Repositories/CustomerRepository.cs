using SimpleCrm.Domain.Entities;
using SimpleCrm.Domain.Interfaces;

namespace SimpleCrm.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly HashSet<Customer> _customers = new HashSet<Customer>()
        {
            new Customer() 
            { 
                Id = Guid.NewGuid(),
                Name = "Jan Kowalski", 
                Email = "j.kowalski@gmail.com", 
                PhoneNumber = "698654632"
            },
            new Customer() 
            {
                Id = Guid.NewGuid(),
                Name = "Comarch", 
                TaxNumber = "6770065406", 
                Email = "info@comarch.pl", 
                PhoneNumber = "(12)6461000"
            },
            new Customer() 
            {
                Id = Guid.NewGuid(),
                Name = "Sellintegro", 
                TaxNumber = "8971813098", 
                Email = "pomoc@sellintegro.pl", 
                PhoneNumber = "+48796300116"
            }
        };

        public IQueryable<Customer> GetAll() 
            => _customers.AsQueryable();


        public Customer GetById(Guid id) 
            => _customers.AsQueryable().SingleOrDefault(x => x.Id == id);
        

        public Customer GetByTaxNumber(string taxNumber) 
            => _customers.AsQueryable().SingleOrDefault(x => x.TaxNumber == taxNumber);
    }
}
