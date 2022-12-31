using FeedbackService.Models;
using FeedbackService.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FeedbackService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;
        public ProductController(IProductRepository _productRepository)
        {
            this.productRepository = _productRepository;
        }

        [HttpGet("GetProduct")]
        public ActionResult GetFeedback()
        {
            return Ok(this.productRepository.GetProducts());
        }
        [HttpPost("GetProductbyId")]
        public ActionResult GetFeedbackbyId(Product id)
        {
            return Ok(this.productRepository.GetProductbyId(id));
        }

        


    }
}
