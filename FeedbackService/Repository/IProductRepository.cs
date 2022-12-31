using FeedbackService.Models;
using System.Collections.Generic;

namespace FeedbackService.Repository
{
    public interface IProductRepository
    {
        IEnumerable <Product> GetProducts();
        Product GetProductbyId(Product product);

    }
}
