using System;
using Microsoft.AspNetCore.Mvc;

namespace API_Example.Controllers
{
    public class CookieController : Controller
    {
        [Route("Cookies/Action1")]
        public string Action1()
        {
            string testCookie = Request.Cookies["testcookie"];
            string testHeader = Request.Headers["testheader"];
            return testCookie + " " + testHeader;
        }

        [Route("Cookies/Action2")]
        public string Action2()
        {
            Response.Cookies.Append("NewCookie", "cookie value", new Microsoft.AspNetCore.Http.CookieOptions { Expires = DateTime.UtcNow.AddDays(30) });
            Response.Headers.Add("NewHeader", "header value");
            return ""; //there is no body
        }
    }
}
