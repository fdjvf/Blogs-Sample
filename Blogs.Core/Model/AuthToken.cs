using System;

namespace Blogs.Data.Model
{
    /// <summary>
    /// Auth tokens use to authenticate through the API
    /// </summary>
    public partial class AuthToken
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Token { get; set; }
        public DateTime ExpirationDate { get; set; }
        public virtual User User { get; set; }
    }
}
