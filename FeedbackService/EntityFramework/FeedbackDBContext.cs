using FeedbackService.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeedbackService.EntityFramework
{
    public class FeedbackDBContext:DbContext
    {
        public FeedbackDBContext(DbContextOptions a) : base(a)
        {

        }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Cart { get; set; }




    }
}
