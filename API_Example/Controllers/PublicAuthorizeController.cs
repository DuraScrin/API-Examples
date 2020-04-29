using System.Collections.Generic;
using API_Example.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API_Example.Controllers
{
    [Route("[Controller]/[Action]")]
    [PublicAuthorize]
    public class PublicAuthorizeController : Controller
    {
        public int Action1()
        {
            return 100;
        }

        public string Action2()
        {
            return "test data";

        }

        public List<string> Action3()
        {
            return new List<string>() { "test 1", "test 2", "test 3", "test 4" };
        }
    }
}
