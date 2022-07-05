using Microsoft.AspNetCore.Mvc;
using Training.Core.Interfaces.Services;
using Training.Core.Models;

namespace Training.Web.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("{id:int}")]
        public CustomerModel Get(int id)
        {
            CustomerModel customer = _customerService.GetCustomerAsync(id);
            return customer;
        }

    }
}
