using System;
using System.ComponentModel.DataAnnotations;


namespace FeedbackService.Models
{
    public class Feedback
    {
        [Key]
        public int FeedbackId { get; set; }
        public string FeedbackGiven { get; set; }
        public string FeedbackBy { get; set; }
        public DateTime FeedbackDate { get; set; }
        
    }
}
