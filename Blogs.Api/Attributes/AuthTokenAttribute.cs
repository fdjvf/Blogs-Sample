﻿using Blogs.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Blogs.Api.Attributes
{
    [AttributeUsage(validOn: AttributeTargets.Class)]
    public class AuthTokenAttribute : Attribute, IAsyncActionFilter
    {
        private const string AuthtTokenName = "AuthToken";

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var notAuthorizedResult = new ContentResult
            {
                StatusCode = 401
            };

            if (!context.HttpContext.Request.Headers.TryGetValue(AuthtTokenName, out var token))
            {
                notAuthorizedResult.Content = "Auth Token was not provided";
                context.Result = notAuthorizedResult;
                return;
            }

            var authService = context.HttpContext.RequestServices.GetRequiredService<IAuthTokenService>();
            var tokenInfo = await authService.GetTokenInfo(token);

            if (tokenInfo == null)
            {
                notAuthorizedResult.Content = "Auth Token does not exist.";
                context.Result = notAuthorizedResult;
                return;
            }

            var userIsEditor = tokenInfo.Roles.Contains("Editor");
            var isExpired = DateTime.Now > tokenInfo.ExpirationDate;

            string errorMessage = "";

            if (!userIsEditor)
                errorMessage = "Invalid Token. User is not editor.";

            if (isExpired)
                errorMessage += "\n Token is expired.";

            if (!string.IsNullOrWhiteSpace(errorMessage))
            {
                notAuthorizedResult.Content = errorMessage;
                context.Result = notAuthorizedResult;
                return;
            }
            
            await next();
        }
    }
}