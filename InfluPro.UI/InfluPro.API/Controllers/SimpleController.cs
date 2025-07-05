using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InfluPro.API.Controllers
{
    [Route("api/[controller]")] //api/controller/action
    [ApiController]
    public class SimpleController : ControllerBase
    {
        [HttpGet("GetDemo1")]
        public string GetDemo1()
        {
            return "This is Gen-Z of Bangladesh!";
        }

        [HttpGet("GetDemo2")]
        public string GetDem2()
        {
            return "Hello H Will you Marry Me!";
        }
    }
}
