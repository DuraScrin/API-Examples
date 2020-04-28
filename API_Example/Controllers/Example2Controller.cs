using Microsoft.AspNetCore.Mvc;

namespace API_Example.Controllers
{
    public class Example2Controller : Controller
    {
        [Route("example2/action1")]
        public string Action1([FromForm]string val1, [FromForm]int val2)
        {
            return val1 + " " + val2;
        }

        [Route("example2/action2")]
        public string Action2([FromQuery]string val1, [FromQuery]int val2)
        {
            return val1 + " " + val2;
        }
    }
}
