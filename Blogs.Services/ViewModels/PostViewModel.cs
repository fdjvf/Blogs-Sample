using Blogs.Data.Model;
using System;
using System.ComponentModel.DataAnnotations;

namespace Blogs.Services.ViewModels
{
    public class PostViewModel
    {
        public Guid Id { get; set; }

        public PostStatus Status { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }
    }
}
