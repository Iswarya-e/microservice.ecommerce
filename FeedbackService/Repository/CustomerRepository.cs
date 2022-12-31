using FeedbackService.EntityFramework;
using FeedbackService.Models;
using System.Collections.Generic;
using System.Linq;

namespace FeedbackService.Repository
{
    public class CustomerRepository:ICustomerRepository
    {
        private readonly FeedbackDBContext feedbackDbContext;
        public CustomerRepository(FeedbackDBContext _feedbackDBContext)
        {
            feedbackDbContext = _feedbackDBContext;
        }
        public int RegisterCustomer(Customer customer)
        {
            this.feedbackDbContext.Customers.Add(customer);
            return this.feedbackDbContext.SaveChanges();
        }

        public IEnumerable<Customer> GetCustomers()
        {
            IEnumerable<Customer> customers = new List<Customer>();
            customers= this.feedbackDbContext.Customers.ToList();
            //foreach(var i in customers)
            //{
            //    i.UserImage ="../assets/"+i.FileName;

            //}
            return customers;
        }
       
    }
}
