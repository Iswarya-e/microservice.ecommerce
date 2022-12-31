using FeedbackService.Models;
using FeedbackService.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FeedbackService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {

        private readonly ICartRepository cartRepository;
        public CartController(ICartRepository _cartRepository)
        {
            this.cartRepository = _cartRepository;
        }


        [HttpPost("AddDatatoCart")]
        public ActionResult Add(Cart cart)
        {

            return Ok(this.cartRepository.AddCartData(cart));
        }

        [HttpDelete("DeletefromCart")]
        public ActionResult Delete(Cart cart)
        {
            return Ok(this.cartRepository.deleteCartData(cart));
        }

        [HttpPost("GetCartData")]
        public ActionResult GetData(Cart userId)
        {
            return Ok(this.cartRepository.GetCartData(userId));
        }

        [HttpPost("GetCartTotal")]
        public ActionResult GetCartTotal(Cart userId)
        {
            return Ok(this.cartRepository.getCartTotal(userId));
        }

    }
}
