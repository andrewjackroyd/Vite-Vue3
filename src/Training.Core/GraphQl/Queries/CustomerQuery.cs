using Training.Core.Interfaces.Services;
using Training.Core.Models;

namespace Training.Core.GraphQl.Queries
{
    public class CustomerQuery
    {
        private readonly ICustomerService _customerService;

        public CustomerQuery(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public CustomerModel GetCustomer()
        {
            CustomerModel customer = _customerService.GetCustomerAsync(1);
            return customer;
        }

        
    }
}
