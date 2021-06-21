using System;

namespace Blogs.Services.Dto
{
    /// <summary>
    /// DTO of Post Model. Used as a respose model in the API
    /// </summary>
    public class PostObject
    {
        public Guid Id { get; set; }
        public string WriterName { get; set; }
        public DateTime SubmitDate { get; set; }
    }
}
