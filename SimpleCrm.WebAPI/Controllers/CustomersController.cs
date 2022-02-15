using Microsoft.AspNetCore.Mvc;
using SimpleCrm.Application.Interfaces;
using Swashbuckle.AspNetCore.Annotations;

namespace SimpleCrm.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [SwaggerOperation(Summary = "Retrieves all customers")]
        [HttpGet]
        public IActionResult Get()
        {
            var customers = _customerService.GetAllCustomers();
            return Ok(customers);
        }

        [SwaggerOperation(Summary = "Retrieves a specific customer by unique id")]
        [HttpGet("{id:guid}")]
        public IActionResult Get(Guid id)
        {
            var customer = _customerService.GetCustomerById(id);
            return customer != null ? Ok(customer) : NotFound();
        }

        [SwaggerOperation(Summary = "Retrieves a specific customer by tax number")]
        [HttpGet("[action]/{taxNumber}")]
        public IActionResult GetByTaxNumber(string taxNumber)
        {
            var customer = _customerService.GetCustomerByTaxNumber(taxNumber);
            return customer != null ? Ok(customer) : NotFound();
        }

        [SwaggerOperation(Summary = "Retrieves all customers for report")]
        [HttpGet("[action]")]
        public IActionResult Get4Report()
        {
            var customers = _customerService.GetAllCustomers4Report();
            return Ok(customers);
        }
    }
}
