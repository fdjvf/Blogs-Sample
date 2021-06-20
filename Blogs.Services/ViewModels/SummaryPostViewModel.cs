using System;

namespace Blogs.Services.ViewModels
{
    public class SummaryPostViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedOn { get; set; }

        private string _ShortDescription;
        public string ShortDescription
        {
            get
            {
                return _ShortDescription;
            }
            set
            {
                _ShortDescription = value.Substring(0, 150) + "...";
            }
        }

    }
}