using API_Example.Model;
using Microsoft.AspNetCore.Mvc;

namespace API_Example.Controllers
{
    public class ServiceController : Controller
    {
        private readonly TestService _testService;
        public ServiceController(TestService testService)
        {
            _testService = testService;
        }

        //option 1
        [Route("service/option1")]
        public string TestRoute()
        {
            return _testService.ReturnString();
        }

        //option 2 (this is good if you have several controllers, ex: one method in each controller)
        [Route("service/option2")]
        public int ReturnInt([FromServices]TestService service)
        {
            return service.ReturnInteger();
        }
    }
}
