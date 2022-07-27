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

        /* Only one method per Query vs2022 */
        public CustomerModel GetCustomer(int id)
        {
            CustomerModel customer = _customerService.GetCustomerAsync(id);
            return customer;
        }

        
    }
}
