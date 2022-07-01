using Microsoft.AspNetCore.Mvc;
using Training.Core.Interfaces.Services;
using Training.Core.Models;

namespace Training.Web.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public List<CustomerModel> GetAll()
        {
            return _customerService.GetAllCustomersAsync();
        }

        [HttpGet("/{id:int}")]
        public CustomerModel Get(int id)
        {
            return _customerService.GetCustomerAsync(id);
        }

    }
}
