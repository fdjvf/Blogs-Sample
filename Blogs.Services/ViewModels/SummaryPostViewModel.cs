using System;

namespace Blogs.Services.ViewModels
{
    /// <summary>
    /// Post model used to show a small part of the post's information during UI interaction
    /// </summary>
    public class SummaryPostViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime? PublishedOn { get; set; }
        public string WriterName { get; set; }
        private string _ShortDescription;
        public string ShortDescription
        {
            get
            {
                return _ShortDescription;
            }
            set
            {
                int maxLength = value.Length > 150 ? 150 : value.Length;
                _ShortDescription = value.Substring(0, maxLength) + "...";
            }
        }

    }
}