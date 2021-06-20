using Microsoft.EntityFrameworkCore;

namespace Blogs.Data.Abstract
{
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
