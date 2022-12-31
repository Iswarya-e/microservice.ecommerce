using FeedbackService.EntityFramework;
using FeedbackService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeedbackService.Repository
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private readonly FeedbackDBContext feedbackDbContext;
        public FeedbackRepository(FeedbackDBContext _feedbackDBContext)
        {
            feedbackDbContext = _feedbackDBContext;
        }
        public int CreateFeedback(Feedback feedback)
        {
            this.feedbackDbContext.Feedbacks.Add(feedback);
            return this.feedbackDbContext.SaveChanges();
        }

        public IEnumerable<Feedback> GetFeedbacks()
        {
            return this.feedbackDbContext.Feedbacks.ToList();
        }
    }
}
