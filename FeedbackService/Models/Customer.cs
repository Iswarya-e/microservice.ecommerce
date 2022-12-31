using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace FeedbackService.Models
{
    public class Customer
    {
        [Key]
        public int UserId { get; set; }
        public string UserName{ get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DOB { get; set; }
        public string UserImage { get; set; }
        public string FileType { get; set; }
        public string FileName { get; set; }
        public string FileAsBase64 { get; set; }
        public byte[] FileAsByteArray { get; internal set; }
    }
}
