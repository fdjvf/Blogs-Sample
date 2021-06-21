using Blogs.Data.Model;
using System.Threading.Tasks;

namespace Blogs.Data.Abstract
{
    /// <summary>
    /// Manages access to <see cref="User"/> objects
    ///</summary>
    public interface IUserRepository
    {
        /// <summary>
        /// Get an user object by their username. Used for Auth purposes.
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        Task<User> GetUserByUserName(string userName);
    }
}
