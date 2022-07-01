using Training.Core.Models;

namespace Training.Core.Interfaces.Services
{
    public interface ICustomerService
    {
        public CustomerModel GetCustomerAsync(int id);
    }
}
