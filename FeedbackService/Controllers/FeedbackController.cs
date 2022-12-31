using FeedbackService.Models;
using FeedbackService.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeedbackService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController : ControllerBase
    {
        private readonly IFeedbackRepository feedbackRepository;
        public FeedbackController(IFeedbackRepository _feedbackRepository)
        {
            this.feedbackRepository = _feedbackRepository;
        }

        [HttpPost("Create")]
        public ActionResult CreateFeedback(Feedback feedback)
        {
            return Ok(this.feedbackRepository.CreateFeedback(feedback));
        }
        [HttpGet("GetFeedback")]
        public ActionResult GetFeedback()
        {
            return Ok(this.feedbackRepository.GetFeedbacks());
        }
    }
}
