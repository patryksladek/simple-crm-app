using AutoMapper;
using SimpleCrm.Application.Dto;
using SimpleCrm.Application.Interfaces;
using SimpleCrm.Domain.Interfaces;


namespace SimpleCrm.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public IEnumerable<CustomerDto> GetAllCustomers()
        {
            var customers = _customerRepository.GetAll();
            return _mapper.Map<IEnumerable<CustomerDto>>(customers);
        }

        public CustomerDto GetCustomerById(Guid id)
        {
            var customer = _customerRepository.GetById(id);
            return _mapper.Map<CustomerDto>(customer);
        }

        public CustomerDto GetCustomerByTaxNumber(string taxNumber)
        {
            var customer = _customerRepository.GetByTaxNumber(taxNumber);
            return _mapper.Map<CustomerDto>(customer);
        }
    }
}
