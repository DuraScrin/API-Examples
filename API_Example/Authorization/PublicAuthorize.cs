using System;
using API_Example.DA;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace API_Example.Authorization
{
    public class PublicAuthorize : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            //If appid & secret are in query = [FromQuery]           
            if (!PublicAuthorizeService.VerifyIdANDSecret(context.HttpContext.Request.Headers["appid"], context.HttpContext.Request.Headers["appsecret"]))
            {
                context.Result = new UnauthorizedResult();
                return;
            }
            if (!PublicAuthorizeService.VerifyScopes(context.HttpContext.Request.Headers["appid"], context.RouteData.Values["Controller"].ToString()))
            {
                context.Result = new UnauthorizedResult();
                return;
            }
        }

        public void OnActionExecuting(ActionExecutingContext context)
        { }
    }

    public class PublicAuthorizeService
    {
        public static bool VerifyIdANDSecret(string appid, string secret)
        {
            return FakeDatabase.apps.Exists(x => x.appid == appid && x.appsecret == secret);
        }

        public static bool VerifyScopes(string appid, string scope)
        {
            bool gn = FakeDatabase.apps.Exists(x => x.appid == appid && x.scopes.Contains(scope));
            return gn;
        }
    }
}
