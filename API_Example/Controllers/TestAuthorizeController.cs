using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API_Example.Controllers
{
    public class TestAuthorizeController : Controller
    {
        [Authorize]
        [Route("testauthorize")]
        public string TestAccess()
        {
            return "Success";
        }
    }
}
