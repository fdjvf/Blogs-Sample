﻿using System;
using System.Collections.Generic;

namespace Blogs.Services.Dto
{
    /// <summary>
    /// DTO of AuthToken model. Used in the API for Auth purposes/>
    /// </summary>
    public class AuthTokenObject
    {
        public string Token { get; set; }
        public Guid UserId { get; set; }
        public IEnumerable<string> Roles { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}