using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace API_Example.Authorization
{
    public class AuthorizeService
    {
        public bool CheckToken(string token)
        {
            return token == "testtoken";
        }
    }

    public class Authorize : Attribute, IActionFilter
    {
        AuthorizeService authorizer = new AuthorizeService();

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.HttpContext.Request.Headers["Auth"] == "")
            {
                context.Result = new UnauthorizedResult();
            }

            if (authorizer.CheckToken(context.HttpContext.Request.Headers["Auth"]))
            {
                //do some extra stuff ex: login time
            }
            else
            {
                context.Result = new UnauthorizedResult();
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            var output = context.Result;
        }
    }
}
