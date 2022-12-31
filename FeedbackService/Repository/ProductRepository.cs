using FeedbackService.EntityFramework;
using FeedbackService.Models;
using System.Collections.Generic;
using System.Linq;

namespace FeedbackService.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly FeedbackDBContext feedbackDbContext;
        public ProductRepository(FeedbackDBContext _feedbackDBContext)
        {
            feedbackDbContext = _feedbackDBContext;
        }
        public Product GetProductbyId(Product product)
        {
           return this.feedbackDbContext.Products.Find(product.productId);

        }

        public IEnumerable<Product> GetProducts()
        {
            return this.feedbackDbContext.Products.ToList();
        }
      
        
    }
}
