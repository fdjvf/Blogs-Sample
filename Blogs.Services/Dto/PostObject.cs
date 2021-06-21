using System;

namespace Blogs.Services.Dto
{
    public class PostObject
    {
        public Guid Id { get; set; }
        public string WriterName { get; set; }
        public DateTime SubmitDate { get; set; }
    }
}
