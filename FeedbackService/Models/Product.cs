using System.ComponentModel.DataAnnotations;
namespace FeedbackService.Models
{
    public class Product
    {
        [Key]
        public int productId { get; set; }
        public string productName { get; set; }
        public string productCode { get; set; }
        public int starRating      { get; set; }
        public  int price { get; set; } 
        public string imageUrl { get; set; }
   
    }
}
