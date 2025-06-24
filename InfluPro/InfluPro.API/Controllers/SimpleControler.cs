using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InfluPro.API.Controllers
{
    [Route("api/[controller]")]  //api/controlar/action
    [ApiController]
    public class SimpleControler : ControllerBase
    {
        // HttpGet, HttpPost, HttpPut, HttpDelete, HttpPatch are action verbs
        [HttpGet("getdemo1")]
        public string GetDemo1()
        {
            return "Hello World, Welcome to API Project";
        }

        [HttpGet("getdemo2")]
        public string GetDemo2()
        {
            return "Hello! Will you marry me!";
        }
    }
}
