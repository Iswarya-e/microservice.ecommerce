using FeedbackService.EntityFramework;
using FeedbackService.Models;
using System.Collections.Generic;
using System.Linq;

namespace FeedbackService.Repository
{
    public class CartRepository : ICartRepository
    {
        private readonly FeedbackDBContext feedbackDbContext;
        public CartRepository(FeedbackDBContext _feedbackDBContext)
        {
            feedbackDbContext = _feedbackDBContext;
        }
        public int AddCartData(Cart cartdata)
        {
            this.feedbackDbContext.Cart.Add(cartdata);
            return this.feedbackDbContext.SaveChanges();
        }

        public int deleteCartData(Cart cartdata)
        {
            this.feedbackDbContext.Cart.Remove(cartdata);
            return this.feedbackDbContext.SaveChanges();

        }

        public List<CartProducts> GetCartData(Cart cart)
        {
            //return this.feedbackDbContext.Cart.Where(i=>i.userId==cart.userId).ToList();
            IEnumerable<Cart> cartitems = this.feedbackDbContext.Cart.Where(i => i.userId == cart.userId).ToList();
            var cartlist = new List<CartProducts>();
            foreach (var i in cartitems)
            {
                var cartData = new CartProducts();
                cartData.ProductId = i.ProductId;
                cartData.userId = i.userId;
                cartData.Id = i.Id;
                var product = this.feedbackDbContext.Products.FirstOrDefault(j => j.productId == i.ProductId);
                cartData.productName = product.productName;
                cartData.productCode = product.productCode;
                cartData.starRating = product.starRating;
                cartData.price = product.price;
                cartData.imageUrl = product.imageUrl;
                cartlist.Add(cartData);
            }
           
            return cartlist;
        }
        public int getCartTotal(Cart cart)
        {
            IEnumerable<Cart> cartitems = this.feedbackDbContext.Cart.Where(i => i.userId == cart.userId).ToList();
            var cartlist = new List<CartProducts>();
            int total = 0;

            foreach (var i in cartitems)
            {
                var product = this.feedbackDbContext.Products.FirstOrDefault(j => j.productId == i.ProductId);

                System.Console.WriteLine(product.price);                
                total += product.price;
            }

            return total;
        }
    }
}
