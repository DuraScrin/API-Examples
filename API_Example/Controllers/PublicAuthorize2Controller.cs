using API_Example.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API_Example.Controllers
{
    [Route("[Controller]/[Action]")]
    [PublicAuthorize]
    public class PublicAuthorize2Controller : Controller
    {
        public bool Action1()
        {
            return true;
        }
        public string Action2()
        {
            return "test data 3";
        }
    }
}
