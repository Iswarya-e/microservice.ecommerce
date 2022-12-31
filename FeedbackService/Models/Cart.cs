using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FeedbackService.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        public int  userId { get; set; } 
        public int ProductId { get; set; }
    }
    public class CartProducts
    {
        [Key]
        public int Id { get; set; }
        public int userId { get; set; }
        public int ProductId { get; set; }
        public string productName { get; set; }
        public string productCode { get; set; }
        public int starRating { get; set; }
        public int price { get; set; }
        public string imageUrl { get; set; }


    }
   
}
