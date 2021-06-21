using System.ComponentModel.DataAnnotations;

namespace Blogs.Services.ViewModels
{
    /// <summary>
    /// Model used for mapping user credentials through the UI
    /// </summary>
    public class LoginViewModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
