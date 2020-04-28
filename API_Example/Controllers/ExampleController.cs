using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API_Example.Controllers
{
    public class ExampleController : ControllerBase
    {
        [Route("Example/action1")]
        public string Action1()
        {
            return Request.Form["val1"] + " " + Request.Form["val2"];
        }

        [Route("Example/action2")]
        public string Action2()
        {
            return Request.Query["val1"] + " " + Request.Query["val2"];

        }

        [Route("Example/action3")]
        public async Task<string> Action3()
        {
            byte[] byteArray = new byte[(int)Request.ContentLength];
            await Request.Body.ReadAsync(byteArray, 0, (int)Request.ContentLength);
            return System.Text.Encoding.UTF8.GetString(byteArray);
        }
    }
}
