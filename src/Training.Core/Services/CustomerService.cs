using Training.Core.Interfaces.Services;
using Training.Core.Models;

namespace Training.Core.Services
{
    public class CustomerService : ICustomerService
    {

        public CustomerModel GetCustomerAsync(int id)
        {
            var laptop = new ProductModel { Id = 1,Description = "Laptop" };
            var customer = new CustomerModel
            {
                Id = 1,
                Code = "CUSTOMER-001",
                Name = "Customer One"
            };

            var laptopOrder = new OrderModel { Id = 1, OrderDate = new DateTime(2022, 7, 1), OrderNumber = 1 };
            laptopOrder.Items.Add(new OrderItem {Id = 1, Product = laptop, Quantity = 10});
            customer.Orders.Add(laptopOrder);
            return customer;
        }
    }
}
