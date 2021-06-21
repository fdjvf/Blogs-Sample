using System;
using System.ComponentModel.DataAnnotations;

namespace Blogs.Services.ViewModels
{
    public class CommentViewModel
    {
        [Required]
        public string Text { get; set; }

        [Required]
        public Guid PostId { get; set; }

        public Guid? WriterId { get; set; }        

        public string WriterName { get; set; }

        public DateTime CreationDate { get; set; }


    }
}
