using AutoMapper;
using External.TaxpayerListAPI.Interfaces;
using SimpleCrm.Application.Dto;
using SimpleCrm.Application.Interfaces;
using SimpleCrm.Application.Models;
using SimpleCrm.Domain.Interfaces;


namespace SimpleCrm.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;
        private readonly ITaxpayerListApiClient _taxpayerListApiClient;

        public CustomerService(ICustomerRepository customerRepository, IMapper mapper, ITaxpayerListApiClient taxpayerListApiClient)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
            _taxpayerListApiClient = taxpayerListApiClient;
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

        public IEnumerable<CustomerReportDto> GetAllCustomers4Report()
        {
            IList<CustomerReportViewModel> customers = new List<CustomerReportViewModel>();
            var customerList = _customerRepository.GetAll();
            foreach (var customer in customerList)
            {
                if (string.IsNullOrEmpty(customer.TaxNumber))
                {
                    customers.Add(new CustomerReportViewModel(customer));
                    continue;
                }

                var customerData = _taxpayerListApiClient.GetCustomerDataFromTaxNumberAsync(customer.TaxNumber);
                customers.Add(new CustomerReportViewModel(customer, customerData.Result.StatusVat, customerData.Result.AccountNumbers));
            }

            return _mapper.Map<IEnumerable<CustomerReportDto>>(customers);
        }
    }
}
