using FeedbackService.Models;
using System.Collections.Generic;

namespace FeedbackService.Repository
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetCustomers();
        int RegisterCustomer(Customer customer);
    }
}
