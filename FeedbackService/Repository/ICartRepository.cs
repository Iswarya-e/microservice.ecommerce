using FeedbackService.Models;
using System.Collections.Generic;

namespace FeedbackService.Repository
{
    public interface ICartRepository
    {
        List<CartProducts> GetCartData(Cart cart);
        int AddCartData(Cart cartdata);
        int deleteCartData(Cart cartdata);
        int getCartTotal(Cart cart);
    }
}
