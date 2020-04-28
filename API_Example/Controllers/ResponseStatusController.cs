using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API_Example.Controllers
{
    public class ResponseStatusController : Controller
    {
        [Route("ResponseStatus/action1")]
        public IActionResult Action1()
        {
            return Ok(0);
        }

        [Route("ResponseStatus/action2")]
        public IActionResult Action2()
        {
            return BadRequest("Something went wrong");
        }

        [Route("ResponseStatus/action3")]
        public string Action3()
        {
            Response.StatusCode = 304;
            return "test response";
        }
    }
}
