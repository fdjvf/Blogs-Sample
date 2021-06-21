using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo(assemblyName: "Blogs.Services")]
namespace Blogs.Data.Abstract
{
    /// <summary>
    /// Abstrac class to enforce all repositories to use a Db property
    /// Any new repository class should inherit from this class
    /// </summary>   
    public abstract class BaseRepository<T>
        where T : DbContext
    {
        /// <summary>
        /// Db context to query the database
        /// </summary>
        protected T Db;

        public BaseRepository(T db)
        {
            Db = db;
        }
    }
}
