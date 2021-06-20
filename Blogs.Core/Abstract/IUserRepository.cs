﻿using Blogs.Data.Model;
using System.Threading.Tasks;

namespace Blogs.Data.Abstract
{
    public interface IUserRepository
    {
        Task<User> GetUserByEmail(string email);
    }
}