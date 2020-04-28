using API_Example.Model;
using Microsoft.AspNetCore.Mvc;

namespace API_Example.Controllers
{
    //This will use model obj for deserialization from body (JSON -> TestObj)
    public class Example3Controller : Controller
    {
        [Route("example3/action1")]
        public string Action([FromBody]TestObject obj)
        {
            return obj.val1 + ";" + obj.val2 + ";" + obj.val3;
        }
    }
}
