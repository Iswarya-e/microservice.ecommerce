using FeedbackService.Models;
using FeedbackService.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;

namespace FeedbackService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        const string FILE_PATH = @"C:\Angular_Training\NewFolder\AngularProject\src\assets\";

        private readonly ICustomerRepository customerRepository;
        public CustomerController(ICustomerRepository _customerRepository)
        {
            this.customerRepository = _customerRepository;
        }

        [HttpPost("CreateUser")]
        public ActionResult RegisterCustomer([FromBody]Customer customer)
        {

            var filePathName = FILE_PATH +customer.UserName+
            DateTime.Now.ToString().Replace("/", "")
       .Replace(":", "").Replace(" ", "") +
       Path.GetExtension(customer.FileName);
            customer.FileName= customer.UserName +DateTime.Now.ToString().Replace("/", "").Replace(":", "").Replace(" ", "") +
       Path.GetExtension(customer.FileName);
            customer.UserImage= "../assets/" + customer.FileName;
            if (customer.FileAsBase64.Contains(","))
            {
                customer.FileAsBase64 = customer.FileAsBase64.Substring(customer.FileAsBase64.IndexOf(",") + 1);
            }

            // Convert base64 encoded string to binary
            customer.FileAsByteArray = Convert.FromBase64String(customer.FileAsBase64);

            // Write binary file to server path
            using (var fs = new FileStream(filePathName, FileMode.CreateNew))
            {
                fs.Write(customer.FileAsByteArray, 0, customer.FileAsByteArray.Length);
            }

            return Ok(this.customerRepository.RegisterCustomer(customer));
        }

        [HttpGet("GetUsers")]
        public ActionResult GetCustomers( )
        {
            return Ok(this.customerRepository.GetCustomers());
        }
      
    }
}
